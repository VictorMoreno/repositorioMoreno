using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NetTopologySuite;
using Peliculas.API;
using System.Text;
using Microsoft.OpenApi.Models;
using Peliculas.API.Compartido.Utilidades;
using Peliculas.API.Compartido.Utilidades.Behaviors;
using Peliculas.API.Compartido.Utilidades.DatosPrueba;
using Peliculas.API.Compartido.Utilidades.Filtros;
using Peliculas.API.Infraestructura;

var builder = WebApplication.CreateBuilder(args);

// Limpiamos el mapeo automatico que hace Identity para el email.
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

builder.Services.BindearFuncionalidadesExtras()
    .BindearRepositorios()
    .BindearCasosDeUso();

builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        sqlServer =>
        {
            sqlServer.UseNetTopologySuite();
        }));

builder.Services.AddCors(options =>
{
    var frontendUrl = builder.Configuration.GetValue<string>("FrontendUrl");

    if (string.IsNullOrEmpty(frontendUrl))
    {
        throw new Exception("FrontendUrl is required");
    }
    
    options.AddDefaultPolicy(policyBuilder =>
    {
        policyBuilder.WithOrigins(frontendUrl).AllowAnyMethod().AllowAnyHeader()
            .WithExposedHeaders("cantidadtotalregistros");
    });
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["jwtKey"])),
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddAuthorization(opciones =>
    opciones.AddPolicy("EsAdmin", policy => policy.RequireClaim(ClaimTypes.Role, "admin")));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ParsearBadRequest>();
}).ConfigureApiBehaviorOptions(BehaviorBadRequest.Parsear);

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Introduce el token JWT en el formato: Bearer {token}"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            }, []
        }
    });
});

builder.Services.AddSingleton(NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        await IdentityConfigurationExtensions.RellenarUsuarios(userManager);
    }
    catch (Exception ex)
    {
        // Manejar errores de inicialización
        Console.WriteLine($"Error al inicializar los datos de Identity: {ex.Message}");
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<MiddlewareExcepcion>();

app.Run();