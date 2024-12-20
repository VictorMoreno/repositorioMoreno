﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Peliculas.API.Compartido.Utilidades.DatosPrueba;
using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.Cines;
using Peliculas.API.Dominio.Generos;
using Peliculas.API.Dominio.Peliculas;
using Peliculas.API.Dominio.Ratings;

namespace Peliculas.API.Infraestructura
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeliculasActores>()
                .HasKey(x => new { x.ActorId, x.PeliculaId });

            modelBuilder.Entity<PeliculasGeneros>()
                .HasKey(x => new { x.GeneroId, x.PeliculaId });

            modelBuilder.Entity<PeliculasCines>()
                .HasKey(x => new { x.CineId, x.PeliculaId });

            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Cine> Cines { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculasActores> PeliculasActores { get; set; }
        public DbSet<PeliculasGeneros> PeliculasGeneros { get; set; }
        public DbSet<PeliculasCines> PeliculasCines { get; set; }
    }
}