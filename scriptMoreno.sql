CREATE DATABASE [PeliculasAPI]
GO

USE [PeliculasAPI]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Actores]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NOT NULL,
	[Biografia] [nvarchar](max) NOT NULL,
	[FechaNacimiento] [datetime2](7) NOT NULL,
	[Foto] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Actores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cines]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](75) NOT NULL,
	[Ubicacion] [geography] NOT NULL,
 CONSTRAINT [PK_Cines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](300) NOT NULL,
	[Resumen] [nvarchar](max) NOT NULL,
	[Trailer] [nvarchar](max) NOT NULL,
	[EnCines] [bit] NOT NULL,
	[FechaLanzamiento] [datetime2](7) NOT NULL,
	[Poster] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeliculasActores]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeliculasActores](
	[PeliculaId] [int] NOT NULL,
	[ActorId] [int] NOT NULL,
	[Personaje] [nvarchar](100) NOT NULL,
	[Orden] [int] NOT NULL,
 CONSTRAINT [PK_PeliculasActores] PRIMARY KEY CLUSTERED 
(
	[ActorId] ASC,
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeliculasCines]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeliculasCines](
	[PeliculaId] [int] NOT NULL,
	[CineId] [int] NOT NULL,
 CONSTRAINT [PK_PeliculasCines] PRIMARY KEY CLUSTERED 
(
	[CineId] ASC,
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeliculasGeneros]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeliculasGeneros](
	[PeliculaId] [int] NOT NULL,
	[GeneroId] [int] NOT NULL,
 CONSTRAINT [PK_PeliculasGeneros] PRIMARY KEY CLUSTERED 
(
	[GeneroId] ASC,
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ratings]    Script Date: 05/12/2024 21:53:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ratings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Puntuacion] [int] NOT NULL,
	[PeliculaId] [int] NOT NULL,
	[UsuarioId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Ratings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240928141428_Initial', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240930201721_Actores', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241006193945_Cines', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241007174219_Peliculas', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241023193422_GestionUsuarios', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241027082954_Ratings', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241106093131_Generos', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241106093923_DatosActores', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241106101438_DatosCines', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241107172935_DatosPeliculas', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241126123357_DatosPeliculasGeneros', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241126140036_Datos PeliculasCines', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241126155429_Datos PeliculasActores', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241127140939_Nuevas PeliculasCine', N'8.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241127151213_Datos Sinopsis', N'8.0.10')
GO
SET IDENTITY_INSERT [dbo].[Actores] ON 

INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (1, N'Leonardo DiCaprio', N'Leonardo DiCaprio es un actor y productor estadounidense conocido por películas como ''Titanic'', ''Inception'' y ''The Revenant''. Ganó un Óscar por ''The Revenant''.', CAST(N'1974-11-11T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/39c562aa-c83d-4bc7-97aa-8895dc46880c.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (2, N'Meryl Streep', N'Meryl Streep es una reconocida actriz estadounidense, famosa por su habilidad para interpretar distintos personajes. Ha ganado tres premios Óscar y es una de las actrices más nominadas en la historia del cine.', CAST(N'1949-06-22T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/ade14658-7f47-496a-ace0-7c1d0414f468.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (3, N'Robert De Niro', N'Robert De Niro es un actor y productor estadounidense, famoso por sus papeles en ''Taxi Driver'', ''Raging Bull'' y ''Goodfellas''. Ha ganado dos premios Óscar.', CAST(N'1943-08-17T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/b0ff03ae-86fa-426b-9ce2-9e4975678026.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (4, N'Scarlett Johansson', N'Scarlett Johansson es una actriz estadounidense conocida por su papel en el Universo Cinematográfico de Marvel como ''Black Widow'' y en películas como ''Lost in Translation''.', CAST(N'1984-11-22T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/ef905ad6-7cb3-46d9-adfc-e2961efd0437.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (5, N'Tom Hanks', N'Tom Hanks es un actor y productor estadounidense conocido por sus papeles en ''Forrest Gump'', ''Saving Private Ryan'' y ''Cast Away''. Ha ganado dos premios Óscar consecutivos.', CAST(N'1956-07-09T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/91510ed1-a7dd-4592-bbc4-e3baa12285c0.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (6, N'Natalie Portman', N'Natalie Portman es una actriz y productora estadounidense-israelí, conocida por su papel en ''Black Swan'', por el que ganó un Óscar, y su participación en la saga ''Star Wars''.', CAST(N'1981-06-09T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/3531dfef-80bd-4e62-b40b-d7f5e89ddb27.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (7, N'Brad Pitt', N'Brad Pitt es un actor y productor estadounidense famoso por sus papeles en ''Fight Club'', ''Inglourious Basterds'' y ''Once Upon a Time in Hollywood'', por el que ganó un Óscar.', CAST(N'1963-12-18T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/fed532b0-86d5-4e3d-9978-cbaf00f53bd2.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (8, N'Emma Stone', N'Emma Stone es una actriz estadounidense conocida por su papel en ''La La Land'', por el cual ganó un Óscar. También es conocida por su trabajo en ''Easy A'' y ''The Amazing Spider-Man''.', CAST(N'1988-11-06T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/626b3111-fd53-40f9-a88c-02dcc38587a2.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (9, N'Morgan Freeman', N'Morgan Freeman es un actor y narrador estadounidense conocido por su voz distintiva y papeles en ''The Shawshank Redemption'', ''Se7en'' y ''Driving Miss Daisy''. Ganó un Óscar en 2005.', CAST(N'1937-06-01T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/76ac4765-8bcd-4075-8bf2-25c601e0a891.jpeg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (10, N'Charlize Theron', N'Charlize Theron es una actriz y productora sudafricana conocida por su papel en ''Monster'', por el que ganó un Óscar, y su actuación en películas de acción como ''Mad Max: Fury Road''.', CAST(N'1975-08-07T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/620ba7f7-38ac-4727-9a7c-8f3f7dcfb47e.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (11, N'Margot Robbie', N'Margot Robbie es una actriz y productora australiana conocida por sus papeles en películas como ''The Wolf of Wall Street'', ''I, Tonya'' y ''Barbie''. Ha sido nominada a varios premios, incluyendo el Óscar, y es reconocida por su versatilidad en papeles dramáticos y cómicos.', CAST(N'1990-07-02T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/8FA42CB3-2A52-4C12-A5D6-EED127CA6139.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (12, N'Ruth Negga', N'Ruth Negga es una actriz irlandesa-etíope conocida por su actuación en ''Loving'', por la que recibió una nominación al Óscar. También ha destacado en series como ''Preacher'' y ''Agents of S.H.I.E.L.D.''.', CAST(N'1981-01-07T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/50D498BD-39F2-42C5-A6B8-781DA33CB01D.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (13, N'Tommy Lee Jones', N'Tommy Lee Jones es un actor y director estadounidense ganador del Óscar, conocido por papeles en películas como ''Men in Black'', ''No Country for Old Men'' y ''The Fugitive''. Es reconocido por su carácter y estilo distintivo en la pantalla.', CAST(N'1946-09-15T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/01CF2324-A586-4A1E-9583-C4A35FFDA084.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (14, N'Sandra Bullock', N'Sandra Bullock es una actriz y productora estadounidense, conocida por su versatilidad en una amplia gama de géneros, desde la comedia en ''Miss Congeniality'' hasta el drama en ''The Blind Side'', película que le valió un Óscar. También ha sido aclamada por sus papeles en ''Gravity'' y ''Bird Box''.', CAST(N'1964-07-26T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/9F0150C5-6584-45D0-9EFC-9E0F78B49BAF.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (15, N'Channing Tatum', N'Channing Tatum es un actor, productor y bailarín estadounidense, conocido por sus papeles en películas como ''Magic Mike'', ''Step Up'' y ''21 Jump Street''. Su habilidad para la danza le ha ayudado a destacarse, además de su presencia en comedias y dramas.', CAST(N'1980-04-26T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/ED6F7AB2-28AB-4AA1-8F0B-F988B4594D5F.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (16, N'George Clooney', N'George Clooney es un actor, director y productor estadounidense, reconocido mundialmente por su trabajo en películas como ''Ocean''s Eleven'', ''Gravity'', ''The Descendants'' y ''Up in the Air''. Ha ganado múltiples premios, incluidos los premios Óscar, y es conocido por su activismo y trabajo humanitario.', CAST(N'1961-05-06T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/74E76C1E-EC0E-4AB2-BA80-A83CE2385235.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (17, N'Timothée Chalamet', N'Timothée Chalamet es un actor estadounidense, conocido por sus papeles en ''Call Me by Your Name'', ''Little Women'', y su participación en ''Dune''. Aclamado por su habilidad actoral, Chalamet ha sido nominado a varios premios importantes, incluidos los premios Óscar.', CAST(N'1995-12-27T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/B5F73E68-8140-4904-9D25-C764CECD0199.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (18, N'Zendaya', N'Zendaya Maree Stoermer Coleman, conocida profesionalmente como Zendaya, es una actriz y cantante estadounidense famosa por su papel en la serie de Disney Channel ''Shake It Up'' y su papel en películas como ''Spider-Man: Homecoming'' y ''Dune''. Además de su carrera en la actuación, Zendaya es una influyente figura en la moda y activismo social.', CAST(N'1996-09-01T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/5D506761-8211-4C40-A4AB-CCC2582A335C.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (19, N'Cliff Curtis', N'Cliff Curtis es un actor neozelandés conocido por sus roles en películas de acción y dramas. Ha trabajado en varias producciones importantes, incluyendo ''Training Day'', ''The Dark Horse'', y ''Avatar''. En la saga de Avatar, interpreta a Tonowari, el líder de la tribu de los Metkayina.', CAST(N'1968-07-27T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/FC2B363B-0FBE-44A3-94FD-9D08E5C72C51.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (20, N'Kate Winslet', N'Kate Winslet es una actriz inglesa ganadora de múltiples premios, incluyendo un Óscar por su papel en ''The Reader''. Es conocida por su capacidad de adaptarse a roles diversos, como en ''Titanic'', ''Eternal Sunshine of the Spotless Mind'', y en la saga de Avatar como la Dr. Ronal.', CAST(N'1975-10-05T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/A77A6BEA-0FDD-49BE-83DB-93F6B81BEAC3.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (21, N'Hayley Atwell', N'Hayley Atwell es una actriz británica conocida por su papel de Peggy Carter en el Universo Cinematográfico de Marvel. Su presencia en ''Misión: Imposible - Sentencia Mortal Parte Dos'' marca una nueva colaboración en el cine de acción, donde interpreta a un personaje clave dentro de la trama.', CAST(N'1982-04-05T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/E4E6F0A2-BDEA-44C4-956A-D86E02CCFA45.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (22, N'Tom Cruise', N'Tom Cruise es uno de los actores más famosos y exitosos de Hollywood, conocido por su papel icónico como Ethan Hunt en la saga ''Misión: Imposible''. Además de ser un actor destacado, ha sido productor de muchas de sus películas y es conocido por sus impresionantes acrobacias y dedicación a sus roles.', CAST(N'1962-07-03T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/7671EC80-98D6-403A-AEC7-4C8A3A7DE2E7.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (23, N'Iman Vellani', N'Iman Vellani es una joven actriz canadiense conocida por interpretar a Kamala Khan/Ms. Marvel en la serie de Disney+ ''Ms. Marvel''. ''The Marvels'' es su participación en el Universo Cinematográfico de Marvel, donde compartirá pantalla con otras heroínas del MCU.', CAST(N'2002-09-03T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/DFD1D3B8-EE44-4B63-A335-B16CE508C80A.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (24, N'Teyonah Parris', N'Teyonah Parris es una actriz estadounidense conocida por su papel como Monica Rambeau en la serie de Disney+ ''WandaVision'' y ahora en ''The Marvels''. Parris ha sido aclamada por su trabajo en la televisión y el cine, destacándose por su versatilidad y talento.', CAST(N'1987-09-22T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/CC6C7B1C-BED7-434A-8F39-404077C11F5F.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (25, N'Brie Larson', N'Brie Larson es una actriz, directora y productora estadounidense conocida por su papel como Carol Danvers/Captain Marvel en el Universo Cinematográfico de Marvel. Ganó el Premio de la Academia a la Mejor Actriz por su actuación en ''Room''. Además de su carrera actoral, Larson también ha incursionado en la dirección de películas.', CAST(N'1989-10-01T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/54CEFD17-5189-46EE-81B1-AC93F0A42CAB.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (26, N'Lady Gaga', N'Lady Gaga es una cantante, compositora y actriz estadounidense, conocida por su estilo musical ecléctico y su presencia en el escenario. Ha ganado múltiples premios, incluidos varios premios Grammy, y su actuación en ''A Star Is Born'' (2018) le valió una nominación al Óscar. En ''Joker: Locura de a Dos'', interpretará a Harley Quinn.', CAST(N'1986-03-28T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/DD1BAEBB-57E2-4D97-834E-79503110E782.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (27, N'Zazie Beetz', N'Zazie Beetz es una actriz alemana-estadounidense conocida por sus papeles en ''Atlanta'', ''Deadpool 2'' y ''Joker''. En ''Joker'', interpretó a Sophie Dumond, un personaje central que tiene una conexión crucial con Arthur Fleck/Joker. Beetz ha sido elogiada por su talento y versatilidad.', CAST(N'1991-06-25T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/757387BF-FA8B-40DA-8F34-BC9156071FFD.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (28, N'Joaquin Phoenix', N'Joaquin Phoenix es un actor, productor y activista estadounidense, conocido por sus papeles en películas como ''Gladiator'', ''Her'' y ''The Master''. Su interpretación del Joker en la película ''Joker'' (2019) le valió el Premio Óscar a Mejor Actor, convirtiéndose en uno de los actores más aclamados de su generación.', CAST(N'1974-10-28T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/7A3B28F1-2CDD-4F5D-9F57-DCD64C2B63A3.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (29, N'Lucas Till', N'Lucas Till es un actor estadounidense conocido por sus papeles en ''X-Men: First Class'' (2011) como Havok, y por protagonizar la serie de televisión ''MacGyver'' (2016-2021) como Angus MacGyver. También ha trabajado en películas como ''Battle: Los Angeles'' (2011) y ''The Disappointments Room'' (2016).', CAST(N'1990-08-10T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/BE15B21C-AE30-4E8D-A4B8-DCD28C027000.jpg')
INSERT [dbo].[Actores] ([Id], [Nombre], [Biografia], [FechaNacimiento], [Foto]) VALUES (30, N'Jason Momoa', N'Jason Momoa es un actor, productor y director estadounidense conocido por sus papeles en la serie de televisión ''Game of Thrones'' como Khal Drogo, y como el superhéroe Aquaman en el universo cinematográfico de DC. También ha trabajado en otras producciones como ''Frontier'', ''The Red Road'' y ''See''. Su presencia en pantalla y su carisma lo han convertido en uno de los actores más populares de la actualidad.', CAST(N'1979-08-01T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/actores/4DACD85F-6223-4AF4-B146-C8115958ED90.jpg')
SET IDENTITY_INSERT [dbo].[Actores] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (1, N'b3f59036-d636-4646-b227-a2417f4c8197', N'role', N'admin')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'97867fde-82e8-40e8-93ed-3286934bc187', N'usuario@ejemplo.com', N'USUARIO@EJEMPLO.COM', N'usuario@ejemplo.com', N'USUARIO@EJEMPLO.COM', 1, N'AQAAAAIAAYagAAAAEFNic9hSy/SvA3zDQiS0dKoY53xmmUdifAG5qKV6rsjwvlEh09UuHMtayjhz1H8jAA==', N'KOIVPL5SOYVLX2GHOZ6UH2CGE2IZBPVW', N'1657a285-cecf-4867-8b92-576eb7a450ff', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b3f59036-d636-4646-b227-a2417f4c8197', N'admin@ejemplo.com', N'ADMIN@EJEMPLO.COM', N'admin@ejemplo.com', N'ADMIN@EJEMPLO.COM', 1, N'AQAAAAIAAYagAAAAEJcqD7Mg8Ctc/Qbhwq8qZ+nQy7eI8SV8iPqxKUJYdqOginZORGCt8kH/0/kIYnTuwg==', N'YKMWOWJCRP35K5VK6CYYJNRYHEI4VF2O', N'60c40de5-a5dd-433e-b4da-53b2cb89119f', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Cines] ON 

INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (1, N'Cines Callao', 0xE6100000010CC974E8F4BC354440E5D4CE30B5A50DC0)
INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (2, N'Yelmo Cines Ideal', 0xE6100000010CA94D9CDCEF344440CD0F1258EFA60DC0)
INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (3, N'Cinesa Diagonal Mar', 0xE6100000010C4AA4236F6FB44440C0BF52A74DB60140)
INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (4, N'Cines Renoir Plaza de España', 0xE6100000010C05FE4BAD52364440C2B755B549BA0DC0)
INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (5, N'Cines Verdi Barcelona', 0xE6100000010C6829B407B5B344403F4A3668F93B0140)
INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (6, N'Ocine Granollers', 0xE6100000010CFC694881AACD44407471659AFA4A0240)
INSERT [dbo].[Cines] ([Id], [Nombre], [Ubicacion]) VALUES (7, N'Kinépolis Valencia', 0xE6100000010CA34FF5752ABD4340129150E91670DBBF)
SET IDENTITY_INSERT [dbo].[Cines] OFF
GO
SET IDENTITY_INSERT [dbo].[Generos] ON 

INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (1, N'Acción')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (2, N'Aventura')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (3, N'Catástrofe')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (4, N'Ciencia Ficción')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (5, N'Comedia')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (6, N'Documentales')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (7, N'Drama')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (8, N'Fantasia')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (9, N'Terror')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (10, N'Romantico')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (11, N'Historica')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (12, N'Suspense')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (13, N'Espionaje')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (14, N'Crimen')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (15, N'Thriller')
SET IDENTITY_INSERT [dbo].[Generos] OFF
GO
SET IDENTITY_INSERT [dbo].[Peliculas] ON 

INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (1, N'Babylon', N'Ambientada en Los Ángeles durante los años 20, cuenta una historia de ambición y excesos desmesurados que recorre la ascensión y caída de múltiples personajes durante una época de desenfrenada decadencia y depravación en los albores de Hollywood.', N'https://www.youtube.com/watch?v=gBil8RpweBE&pp=ygUYYmFieWxvbiB0cmFpbGVyIGVzcGHDsW9s', 1, CAST(N'2022-12-23T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/ea9fd07a-1fb5-4eb7-a01a-1c27266c2309.png')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (2, N'Érase una vez en… Hollywood', N'Hollywood, años 60. La estrella de un western televisivo, Rick Dalton (DiCaprio), intenta amoldarse a los cambios del medio al mismo tiempo que su doble (Pitt). La vida de Dalton está ligada completamente a Hollywood, y es vecino de la joven y prometedora actriz y modelo Sharon Tate (Robbie) que acaba de casarse con el prestigioso director Roman Polanski.', N'https://www.youtube.com/watch?v=J0rFGJV3cYw', 1, CAST(N'2019-07-26T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/14a89f1e-d997-46ec-ae77-37b43118b00c.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (3, N'Ad Astra', N'El astronauta Roy McBride (Brad Pitt) viaja a los límites exteriores del sistema solar para encontrar a su padre perdido y desentrañar un misterio que amenaza la supervivencia de nuestro planeta. Su viaje desvelará secretos que desafían la naturaleza de la existencia humana y nuestro lugar en el cosmos.', N'https://www.youtube.com/watch?v=2hy4clp3IMM', 1, CAST(N'2019-09-20T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/eecfa05e-7968-474a-93c4-3f5b24e5cb66.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (4, N'La ciudad perdida', N'La carrera literaria de la brillante y algo huraña escritora de novelas Loretta Sage (Sandra Bullock) ha girado en torno a las novelas románticas de aventuras que, ambientadas en lugares exóticos, protagoniza un atractivo galán cuya imagen aparece reproducida en todas las portadas, y que en la vida real corresponde a Alan (Channing Tatum), un modelo que ha centrado su carrera en personificar al novelesco aventurero. Durante una gira para promocionar su nuevo libro junto a Alan, Loretta es raptada por un excéntrico multimillonario (Daniel Radcliffe), con la intención de que la autora le guíe hasta el tesoro de la antigua ciudad perdida sobre el que gira su último relato. Deseoso de demostrar que puede ser un héroe en la vida real, y no simplemente en las páginas de sus obras de ficción, Alan se lanza al rescate de la novelista.', N'https://www.youtube.com/watch?v=DWq5cjkxEQQ', 1, CAST(N'2022-03-25T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/0acee9d1-94df-4229-aab0-bf7c308e2933.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (5, N'Wolves', N'Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.', N'https://www.youtube.com/watch?v=Ti_7suoHmRQ', 0, CAST(N'2025-06-15T00:00:00.0000000' AS DateTime2), N'')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (6, N'Dune: Parte dos', N'Tras los sucesos de la primera parte acontecidos en el planeta Arrakis, el joven Paul Atreides se une a la tribu de los Fremen y comienza un viaje espiritual y marcial para convertirse en mesías, mientras intenta evitar el horrible pero inevitable futuro que ha presenciado: una Guerra Santa en su nombre, que se extiende por todo el universo conocido... Secuela de ''Dune'' (2021).', N'https://www.youtube.com/watch?v=6OmJF6VjKMA', 1, CAST(N'2024-03-15T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/98e8356c-3214-454f-b6c5-81f82de778ff.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (7, N'Avatar 3', N'La tercera entrega de la saga "Avatar", presenta al Pueblo de las Cenizas, un clan Na''vi no tan pacífico que utilizará la violencia si lo necesita para conseguir sus objetivos, aunque sea contra otros clanes.', N'https://www.youtube.com/watch?v=YXtWPVFk5TQ', 0, CAST(N'2025-12-19T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/aad70b69-1dd1-4b5a-8e4a-1941c00fe96f.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (8, N'Misión: Imposible - Sentencia Mortal Parte Dos', N'Ethan Hunt continúa su lucha contra una nueva amenaza global en la segunda parte de esta entrega de alta tensión y acción.', N'https://www.youtube.com/watch?v=8jRMVhGwy0M', 1, CAST(N'2024-06-28T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/ec9ebb58-73f3-4a0e-ae57-2e7de11da751.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (9, N'The Marvels', N'Carol Danvers, alias Capitana Marvel, ha recuperado la identidad que le arrebataron los tiránicos Kree y se ha cobrado su venganza contra la Inteligencia Suprema. Pero una serie de consecuencias imprevistas la obligan a cargar con el peso de un universo desestabilizado. Cuando el deber la lleva hasta un anómalo agujero de gusano vinculado a una revolucionaria Kree, sus poderes se conectan con los de su superfán de Nueva Jersey Kamala Khan, también conocida como Ms. Marvel, y con los de su sobrina, con la que está distanciada y es ahora astronauta en S.A.B.E.R., la capitana Monica Rambeau. Juntas, las integrantes de este insólito trío tendrán que unir fuerzas y aprender a trabajar en equipo como ''The Marvels'' para salvar el universo.', N'https://www.youtube.com/watch?v=gdSGIf8kbhg', 1, CAST(N'2024-11-08T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/c2eb8dbc-9a1f-4bbe-a8d5-346999a51022.jpg')
INSERT [dbo].[Peliculas] ([Id], [Titulo], [Resumen], [Trailer], [EnCines], [FechaLanzamiento], [Poster]) VALUES (10, N'Joker: locura de a dos', N'Tras crear el caos, Arthur Fleck ha sido internado en Arkham a la espera de juicio por sus crímenes como Joker. Mientras lidia con su doble identidad, Arthur no sólo se topa con el amor verdadero, sino que también descubre la música que siempre ha estado dentro de él. Secuela de ''Joker'' (2019).', N'https://www.youtube.com/watch?v=7SZfThvjt5I', 1, CAST(N'2024-10-04T00:00:00.0000000' AS DateTime2), N'https://localhost:7290/peliculas/c900cffe-1828-46f1-9893-99b86ec064ab.png')
SET IDENTITY_INSERT [dbo].[Peliculas] OFF
GO
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (2, 1, N'Rick Dalton', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (1, 7, N'Jack Conrad', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (2, 7, N'Cliff Booth', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (3, 7, N'Roy McBride', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (4, 7, N'Jack Trainer', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (1, 11, N'Nellie LaRoy', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (2, 11, N'Sharon Tate', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (3, 12, N'Helen Lantos', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (3, 13, N'Clifford McBride', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (4, 14, N'Loretta Sage', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (4, 15, N'Dash McMahon', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (6, 17, N'Paul Atreides', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (6, 18, N'Chani', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (7, 19, N'Tonowari', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (7, 20, N'Ronal', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (8, 21, N'Grace', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (8, 22, N'Ethan Hunt', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (9, 23, N'Kamala Khan', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (9, 24, N'Monica Parris', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (9, 25, N'Carol Danvers', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (10, 26, N'Lee Quinzel', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (10, 27, N'Sophie Dumond', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (10, 28, N'Arthur Fleck', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (5, 29, N'Cayden Richards', 0)
INSERT [dbo].[PeliculasActores] ([PeliculaId], [ActorId], [Personaje], [Orden]) VALUES (5, 30, N'Connor', 0)
GO
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (1, 3)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (1, 4)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (2, 1)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (3, 3)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (3, 5)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (3, 7)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (4, 7)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (5, 2)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (6, 1)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (6, 3)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (6, 4)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (6, 5)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (7, 1)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (8, 5)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (9, 3)
INSERT [dbo].[PeliculasCines] ([PeliculaId], [CineId]) VALUES (10, 7)
GO
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (1, 5)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (1, 7)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (1, 11)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (2, 5)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (2, 7)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (3, 4)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (3, 7)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (4, 1)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (4, 2)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (4, 5)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (5, 1)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (5, 12)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (6, 1)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (6, 2)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (6, 7)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (7, 4)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (7, 8)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (8, 1)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (8, 13)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (9, 1)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (9, 2)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (9, 4)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (10, 7)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (10, 14)
INSERT [dbo].[PeliculasGeneros] ([PeliculaId], [GeneroId]) VALUES (10, 15)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 05/12/2024 21:53:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 05/12/2024 21:53:48 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PeliculasActores_PeliculaId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_PeliculasActores_PeliculaId] ON [dbo].[PeliculasActores]
(
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PeliculasCines_PeliculaId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_PeliculasCines_PeliculaId] ON [dbo].[PeliculasCines]
(
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PeliculasGeneros_PeliculaId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_PeliculasGeneros_PeliculaId] ON [dbo].[PeliculasGeneros]
(
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Ratings_PeliculaId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_Ratings_PeliculaId] ON [dbo].[Ratings]
(
	[PeliculaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Ratings_UsuarioId]    Script Date: 05/12/2024 21:53:48 ******/
CREATE NONCLUSTERED INDEX [IX_Ratings_UsuarioId] ON [dbo].[Ratings]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[PeliculasActores]  WITH CHECK ADD  CONSTRAINT [FK_PeliculasActores_Actores_ActorId] FOREIGN KEY([ActorId])
REFERENCES [dbo].[Actores] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeliculasActores] CHECK CONSTRAINT [FK_PeliculasActores_Actores_ActorId]
GO
ALTER TABLE [dbo].[PeliculasActores]  WITH CHECK ADD  CONSTRAINT [FK_PeliculasActores_Peliculas_PeliculaId] FOREIGN KEY([PeliculaId])
REFERENCES [dbo].[Peliculas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeliculasActores] CHECK CONSTRAINT [FK_PeliculasActores_Peliculas_PeliculaId]
GO
ALTER TABLE [dbo].[PeliculasCines]  WITH CHECK ADD  CONSTRAINT [FK_PeliculasCines_Cines_CineId] FOREIGN KEY([CineId])
REFERENCES [dbo].[Cines] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeliculasCines] CHECK CONSTRAINT [FK_PeliculasCines_Cines_CineId]
GO
ALTER TABLE [dbo].[PeliculasCines]  WITH CHECK ADD  CONSTRAINT [FK_PeliculasCines_Peliculas_PeliculaId] FOREIGN KEY([PeliculaId])
REFERENCES [dbo].[Peliculas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeliculasCines] CHECK CONSTRAINT [FK_PeliculasCines_Peliculas_PeliculaId]
GO
ALTER TABLE [dbo].[PeliculasGeneros]  WITH CHECK ADD  CONSTRAINT [FK_PeliculasGeneros_Generos_GeneroId] FOREIGN KEY([GeneroId])
REFERENCES [dbo].[Generos] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeliculasGeneros] CHECK CONSTRAINT [FK_PeliculasGeneros_Generos_GeneroId]
GO
ALTER TABLE [dbo].[PeliculasGeneros]  WITH CHECK ADD  CONSTRAINT [FK_PeliculasGeneros_Peliculas_PeliculaId] FOREIGN KEY([PeliculaId])
REFERENCES [dbo].[Peliculas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PeliculasGeneros] CHECK CONSTRAINT [FK_PeliculasGeneros_Peliculas_PeliculaId]
GO
ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_AspNetUsers_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_AspNetUsers_UsuarioId]
GO
ALTER TABLE [dbo].[Ratings]  WITH CHECK ADD  CONSTRAINT [FK_Ratings_Peliculas_PeliculaId] FOREIGN KEY([PeliculaId])
REFERENCES [dbo].[Peliculas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ratings] CHECK CONSTRAINT [FK_Ratings_Peliculas_PeliculaId]
GO
