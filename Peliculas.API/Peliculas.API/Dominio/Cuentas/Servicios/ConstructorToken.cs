using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Peliculas.API.DTOs;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Peliculas.API.Dominio.Cuentas.Servicios
{
    public class ConstructorToken
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public ConstructorToken(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            this._userManager = userManager;
            this._configuration = configuration;
        }

        public async Task<RespuestaAutenticacion> Generar(string email, string password)
        {
            var claims = new List<Claim>()
            {
                new Claim("email", email)
            };

            IdentityUser? usuario = await this._userManager.FindByEmailAsync(email);
            IList<Claim> claimsRegistrados = await this._userManager.GetClaimsAsync(usuario);

            claims.AddRange(claimsRegistrados);

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this._configuration["jwtKey"]));
            SigningCredentials credenciales = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            DateTime expiracion = DateTime.UtcNow.AddHours(1);

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: null,
                audience: null,
                claims: claims,
                expires: expiracion,
                signingCredentials: credenciales);

            return new RespuestaAutenticacion
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiracion = expiracion
            };
        }
    }
}
