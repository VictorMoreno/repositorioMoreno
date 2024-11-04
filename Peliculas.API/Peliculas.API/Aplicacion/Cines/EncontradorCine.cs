﻿using Peliculas.API.DTOs;
using Peliculas.API.Entidades;
using Peliculas.API.Repositorios;

namespace Peliculas.API.Aplicacion.Cines
{
    public class EncontradorCine : IServicioAplicacion
    {
        private readonly ICineRepositorio _repository;

        public EncontradorCine(ICineRepositorio repository)
        {
            this._repository = repository;
        }

        public async Task<CineDto> Ejecutar(int id)
        {
            Cine cine = await this._repository.ObtenerPorId(id);

            if (cine == null)
            {
                throw new FileNotFoundException();
            }

            return cine.ToDto();
        }
    }
}
