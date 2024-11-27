using Microsoft.AspNetCore.Identity;

namespace Peliculas.API.Aplicacion.Cuentas.Dtos;

public static class UsuarioDtoExtensiones
{
    public static UsuarioDto ToDto(this IdentityUser usuario)
    {
        return new UsuarioDto
        {
            Id = usuario.Id,
            Email = usuario.Email
        };
    }
}