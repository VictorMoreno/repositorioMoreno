using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NetTopologySuite;
using NetTopologySuite.Geometries;
using Peliculas.API;
using Peliculas.API.APIBehaviors;
using Peliculas.API.Filtros;
using Peliculas.API.Repositorios;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Limpiamos el mapeo automatico que hace Identity para el email.
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

builder.Services.AddTransient<IGeneroRepositorio, BaseDatosGeneroRepositorio>();
builder.Services.AddTransient<IActorRepositorio, BaseDatosActorRepositorio>();
builder.Services.AddTransient<ICineRepositorio, BaseDatosCineRepositorio>();
builder.Services.AddTransient<IPeliculaRepositorio, BaseDatosPeliculaRepositorio>();
builder.Services.AddTransient<IUsuarioRepositorio, BaseDatosUsuarioRepositorio>();
builder.Services.AddTransient<IRatingRepositorio, BaseDatosRatingRepositorio>();
builder.Services.AddTransient<IAlmacenadorArchivoRepositorio, AlmacenadorArchivoLocal>();
builder.Services.AddTransient<IProveedorContenedor, ProveedorManualContenedor>();
builder.Services.BindearCasosDeUso();

builder.Services.AddHttpContextAccessor();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetConnectionString("jwtKey"))),
        ClockSkew = TimeSpan.Zero
    });

builder.Services.AddAuthorization(opciones =>
    opciones.AddPolicy("EsAdmin", policy => policy.RequireClaim("rol", "admin")));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<FiltroExcepcion>();
    options.Filters.Add<ParsearBadRequest>();
}).ConfigureApiBehaviorOptions(BehaviorBadRequest.Parsear);

builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlServer => sqlServer.UseNetTopologySuite()));

builder.Services.AddSingleton<GeometryFactory>(NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326));

builder.Services.AddCors(options =>
{
    var frontendUrl = builder.Configuration.GetValue<string>("FrontendUrl");
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontendUrl).AllowAnyMethod().AllowAnyHeader()
        .WithExposedHeaders(new string[] { "cantidadtotalregistros" });
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
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

app.Run();
