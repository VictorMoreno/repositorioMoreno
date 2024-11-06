﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Peliculas.API;

#nullable disable

namespace Peliculas.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241106122658_DatosPeliculas")]
    partial class DatosPeliculas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Actores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biografia = "Leonardo DiCaprio es un actor y productor estadounidense conocido por películas como 'Titanic', 'Inception' y 'The Revenant'. Ganó un Óscar por 'The Revenant'.",
                            FechaNacimiento = new DateTime(1974, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/39c562aa-c83d-4bc7-97aa-8895dc46880c.jpg",
                            Nombre = "Leonardo DiCaprio"
                        },
                        new
                        {
                            Id = 2,
                            Biografia = "Meryl Streep es una reconocida actriz estadounidense, famosa por su habilidad para interpretar distintos personajes. Ha ganado tres premios Óscar y es una de las actrices más nominadas en la historia del cine.",
                            FechaNacimiento = new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/ade14658-7f47-496a-ace0-7c1d0414f468.jpg",
                            Nombre = "Meryl Streep"
                        },
                        new
                        {
                            Id = 3,
                            Biografia = "Robert De Niro es un actor y productor estadounidense, famoso por sus papeles en 'Taxi Driver', 'Raging Bull' y 'Goodfellas'. Ha ganado dos premios Óscar.",
                            FechaNacimiento = new DateTime(1943, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/b0ff03ae-86fa-426b-9ce2-9e4975678026.jpg",
                            Nombre = "Robert De Niro"
                        },
                        new
                        {
                            Id = 4,
                            Biografia = "Scarlett Johansson es una actriz estadounidense conocida por su papel en el Universo Cinematográfico de Marvel como 'Black Widow' y en películas como 'Lost in Translation'.",
                            FechaNacimiento = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/ef905ad6-7cb3-46d9-adfc-e2961efd0437.jpg",
                            Nombre = "Scarlett Johansson"
                        },
                        new
                        {
                            Id = 5,
                            Biografia = "Tom Hanks es un actor y productor estadounidense conocido por sus papeles en 'Forrest Gump', 'Saving Private Ryan' y 'Cast Away'. Ha ganado dos premios Óscar consecutivos.",
                            FechaNacimiento = new DateTime(1956, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/91510ed1-a7dd-4592-bbc4-e3baa12285c0.jpg",
                            Nombre = "Tom Hanks"
                        },
                        new
                        {
                            Id = 6,
                            Biografia = "Natalie Portman es una actriz y productora estadounidense-israelí, conocida por su papel en 'Black Swan', por el que ganó un Óscar, y su participación en la saga 'Star Wars'.",
                            FechaNacimiento = new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/3531dfef-80bd-4e62-b40b-d7f5e89ddb27.jpg",
                            Nombre = "Natalie Portman"
                        },
                        new
                        {
                            Id = 7,
                            Biografia = "Brad Pitt es un actor y productor estadounidense famoso por sus papeles en 'Fight Club', 'Inglourious Basterds' y 'Once Upon a Time in Hollywood', por el que ganó un Óscar.",
                            FechaNacimiento = new DateTime(1963, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/fed532b0-86d5-4e3d-9978-cbaf00f53bd2.jpg",
                            Nombre = "Brad Pitt"
                        },
                        new
                        {
                            Id = 8,
                            Biografia = "Emma Stone es una actriz estadounidense conocida por su papel en 'La La Land', por el cual ganó un Óscar. También es conocida por su trabajo en 'Easy A' y 'The Amazing Spider-Man'.",
                            FechaNacimiento = new DateTime(1988, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/626b3111-fd53-40f9-a88c-02dcc38587a2.jpg",
                            Nombre = "Emma Stone"
                        },
                        new
                        {
                            Id = 9,
                            Biografia = "Morgan Freeman es un actor y narrador estadounidense conocido por su voz distintiva y papeles en 'The Shawshank Redemption', 'Se7en' y 'Driving Miss Daisy'. Ganó un Óscar en 2005.",
                            FechaNacimiento = new DateTime(1937, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/76ac4765-8bcd-4075-8bf2-25c601e0a891.jpeg",
                            Nombre = "Morgan Freeman"
                        },
                        new
                        {
                            Id = 10,
                            Biografia = "Charlize Theron es una actriz y productora sudafricana conocida por su papel en 'Monster', por el que ganó un Óscar, y su actuación en películas de acción como 'Mad Max: Fury Road'.",
                            FechaNacimiento = new DateTime(1975, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "https://localhost:7290/actores/620ba7f7-38ac-4727-9a7c-8f3f7dcfb47e.jpg",
                            Nombre = "Charlize Theron"
                        });
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<Point>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.HasKey("Id");

                    b.ToTable("Cines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Cines Callao",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-3.705912 40.419829)")
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Yelmo Cines Ideal",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-3.7065112 40.41357)")
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Cinesa Diagonal Mar",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (2.2140153 41.4096507)")
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Cines Renoir Plaza de España",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-3.7159609 40.4243981)")
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Cines Verdi Barcelona",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (2.1542843 41.4039621)")
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Ocine Granollers",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (2.2866108 41.6067659)")
                        },
                        new
                        {
                            Id = 7,
                            Nombre = "Kinépolis Valencia",
                            Ubicacion = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-0.4287164 39.4778583)")
                        });
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Generos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Acción"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Aventura"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Catástrofe"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Ciencia Ficción"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Comedia"
                        },
                        new
                        {
                            Id = 6,
                            Nombre = "Documentales"
                        },
                        new
                        {
                            Id = 7,
                            Nombre = "Drama"
                        },
                        new
                        {
                            Id = 8,
                            Nombre = "Fantasia"
                        },
                        new
                        {
                            Id = 9,
                            Nombre = "Terror"
                        },
                        new
                        {
                            Id = 10,
                            Nombre = "Romantico"
                        });
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EnCines")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaLanzamiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EnCines = true,
                            FechaLanzamiento = new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Poster = "",
                            Resumen = "Una épica historia sobre el exceso, la decadencia y los sueños rotos en el Hollywood de los años 20, donde la transición del cine mudo al sonoro sacude a la industria.",
                            Titulo = "Babylon",
                            Trailer = "https://www.youtube.com/watch?v=hf5faotVKmo"
                        },
                        new
                        {
                            Id = 2,
                            EnCines = true,
                            FechaLanzamiento = new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Poster = "",
                            Resumen = "Un actor de televisión y su doble de riesgo se encuentran con los eventos de 1969 en Hollywood mientras las estrellas de cine se enfrentan a un cambio cultural.",
                            Titulo = "Once Upon a Time in Hollywood",
                            Trailer = "https://www.youtube.com/watch?v=ELeMaP8EPAA"
                        },
                        new
                        {
                            Id = 3,
                            EnCines = true,
                            FechaLanzamiento = new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Poster = "",
                            Resumen = "Un astronauta viaja a los rincones más distantes del sistema solar para encontrar a su padre y resolver un misterio que amenaza la supervivencia de la Tierra.",
                            Titulo = "Ad Astra",
                            Trailer = "https://www.youtube.com/watch?v=J5VAs99gJjY"
                        },
                        new
                        {
                            Id = 4,
                            EnCines = true,
                            FechaLanzamiento = new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Poster = "",
                            Resumen = "Una escritora de novelas románticas es secuestrada por un millonario que busca un tesoro perdido en una isla remota, y es rescatada por su modelo de portada.",
                            Titulo = "The Lost City",
                            Trailer = "https://www.youtube.com/watch?v=mfjZHsWqL1g"
                        },
                        new
                        {
                            Id = 5,
                            EnCines = false,
                            FechaLanzamiento = new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Poster = "",
                            Resumen = "Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.",
                            Titulo = "Wolves",
                            Trailer = "https://www.youtube.com/watch?v=example"
                        });
                });

            modelBuilder.Entity("Peliculas.API.Entidades.PeliculasActores", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActorId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasActores");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.PeliculasCines", b =>
                {
                    b.Property<int>("CineId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("CineId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasCines");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.PeliculasGeneros", b =>
                {
                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("GeneroId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("PeliculasGeneros");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("Puntuacion")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Peliculas.API.Entidades.PeliculasActores", b =>
                {
                    b.HasOne("Peliculas.API.Entidades.Actor", "Actor")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.API.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasActores")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.PeliculasCines", b =>
                {
                    b.HasOne("Peliculas.API.Entidades.Cine", "Cine")
                        .WithMany("PeliculasCines")
                        .HasForeignKey("CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.API.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasCines")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cine");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.PeliculasGeneros", b =>
                {
                    b.HasOne("Peliculas.API.Entidades.Genero", "Genero")
                        .WithMany("PeliculasGeneros")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.API.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculasGeneros")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Rating", b =>
                {
                    b.HasOne("Peliculas.API.Entidades.Pelicula", "Pelicula")
                        .WithMany()
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Actor", b =>
                {
                    b.Navigation("PeliculasActores");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Cine", b =>
                {
                    b.Navigation("PeliculasCines");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Genero", b =>
                {
                    b.Navigation("PeliculasGeneros");
                });

            modelBuilder.Entity("Peliculas.API.Entidades.Pelicula", b =>
                {
                    b.Navigation("PeliculasActores");

                    b.Navigation("PeliculasCines");

                    b.Navigation("PeliculasGeneros");
                });
#pragma warning restore 612, 618
        }
    }
}
