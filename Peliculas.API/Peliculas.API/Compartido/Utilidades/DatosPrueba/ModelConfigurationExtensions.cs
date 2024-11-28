using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using Peliculas.API.Dominio.Actores;
using Peliculas.API.Dominio.Cines;
using Peliculas.API.Dominio.Generos;
using Peliculas.API.Dominio.Peliculas;

namespace Peliculas.API.Compartido.Utilidades.DatosPrueba;

public static class ModelConfigurationExtensions
{
    private const int IdGeneroAcción = 1;
    private const int IdGeneroAventura = 2;
    private const int IdGeneroCatástrofe = 3;
    private const int IdGeneroCienciaFiccion = 4;
    private const int IdGeneroComedia = 5;
    private const int IdGeneroDocumentales = 6;
    private const int IdGeneroDrama = 7;
    private const int IdGeneroFantasia = 8;
    private const int IdGeneroTerror = 9;
    private const int IdGeneroRomantico = 10;
    private const int IdGeneroHistorica = 11;
    private const int IdGeneroSuspense = 12;
    private const int IdGeneroEspionaje = 13;
    private const int IdGeneroCrimen = 14;
    private const int IdGeneroThriller = 15;

    private const int IdPeliculaBabylon = 1;
    private const int IdPeliculaHollywood = 2;
    private const int IdPeliculaAdAstra = 3;
    private const int IdPeliculaCiudadPerdida = 4;
    private const int IdPeliculaWolves = 5;
    private const int IdPeliculaDune = 6;
    private const int IdPeliculaAvatar = 7;
    private const int IdPeliculaMisionImposible = 8;
    private const int IdPeliculaMarvels = 9;
    private const int IdPeliculaJoker = 10;

    private const int IdCineCallao = 1;
    private const int IdCineYelmoIdeal = 2;
    private const int IdCineDiagonal = 3;
    private const int IdCineRenoir = 4;
    private const int IdCineVerdi = 5;
    private const int IdCineGranollers = 6;
    private const int IdCineKinepolisValencia = 7;

    private const int IdActorLeonardo = 1;
    private const int IdActorMerylStreep = 2;
    private const int IdActorRobertDeNiro = 3;
    private const int IdActorScarlettJohansson = 4;
    private const int IdActorTomHanks = 5;
    private const int IdActorNataliePortman = 6;
    private const int IdActorBradPitt = 7;
    private const int IdActorEmmaStone = 8;
    private const int IdActorMorganFreeman = 9;
    private const int IdActorCharlizeTheron = 10;
    private const int IdActorMargot = 11;
    private const int IdActorRuth = 12;
    private const int IdActorTommy = 13;
    private const int IdActorSandra = 14;
    private const int IdActorChanning = 15;
    private const int IdActorGeorge = 16;
    private const int IdActorTimothee = 17;
    private const int IdActorZendaya = 18;
    private const int IdActorCliffCurtis = 19;
    private const int IdActorKateWinslet = 20;
    private const int IdActorHayleyAtwell = 21;
    private const int IdActorTomCruise = 22;
    private const int IdActorImanVellani = 23;
    private const int IdActorTeyonahParris = 24;
    private const int IdActorBrieLarson = 25;
    private const int IdActorLadyGaga = 26;
    private const int IdActorZazieBeetz = 27;
    private const int IdActorJoaquinPhoenix = 28;
    private const int IdActorLucasTill = 29;
    private const int IdActorJasonMomoa = 30;

    public static void Seed(this ModelBuilder modelBuilder)
    {
        RellenarGeneros(modelBuilder);
        RellenarActores(modelBuilder);
        RellenarCines(modelBuilder);
        RellenarPeliculas(modelBuilder);
        RellenarPeliculasGeneros(modelBuilder);
        RellenarPeliculasCines(modelBuilder);
        RellenarPeliculasActores(modelBuilder);
    }

    private static void RellenarPeliculasActores(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeliculasActores>().HasData(
            new PeliculasActores
                { PeliculaId = IdPeliculaBabylon, ActorId = IdActorBradPitt, Personaje = "Jack Conrad" },
            new PeliculasActores
                { PeliculaId = IdPeliculaBabylon, ActorId = IdActorMargot, Personaje = "Nellie LaRoy" },
            new PeliculasActores
                { PeliculaId = IdPeliculaHollywood, ActorId = IdActorBradPitt, Personaje = "Cliff Booth" },
            new PeliculasActores
                { PeliculaId = IdPeliculaHollywood, ActorId = IdActorLeonardo, Personaje = "Rick Dalton" },
            new PeliculasActores
                { PeliculaId = IdPeliculaHollywood, ActorId = IdActorMargot, Personaje = "Sharon Tate" },
            new PeliculasActores
                { PeliculaId = IdPeliculaAdAstra, ActorId = IdActorBradPitt, Personaje = "Roy McBride" },
            new PeliculasActores { PeliculaId = IdPeliculaAdAstra, ActorId = IdActorRuth, Personaje = "Helen Lantos" },
            new PeliculasActores
                { PeliculaId = IdPeliculaAdAstra, ActorId = IdActorTommy, Personaje = "Clifford McBride" },
            new PeliculasActores
                { PeliculaId = IdPeliculaCiudadPerdida, ActorId = IdActorBradPitt, Personaje = "Jack Trainer" },
            new PeliculasActores
                { PeliculaId = IdPeliculaCiudadPerdida, ActorId = IdActorSandra, Personaje = "Loretta Sage" },
            new PeliculasActores
                { PeliculaId = IdPeliculaCiudadPerdida, ActorId = IdActorChanning, Personaje = "Dash McMahon" },
            new PeliculasActores { PeliculaId = IdPeliculaWolves, ActorId = IdActorJasonMomoa, Personaje = "Connor" },
            new PeliculasActores
                { PeliculaId = IdPeliculaWolves, ActorId = IdActorLucasTill, Personaje = "Cayden Richards" },
            new PeliculasActores
                { PeliculaId = IdPeliculaDune, ActorId = IdActorTimothee, Personaje = "Paul Atreides" },
            new PeliculasActores { PeliculaId = IdPeliculaDune, ActorId = IdActorZendaya, Personaje = "Chani" },
            new PeliculasActores
                { PeliculaId = IdPeliculaAvatar, ActorId = IdActorCliffCurtis, Personaje = "Tonowari" },
            new PeliculasActores { PeliculaId = IdPeliculaAvatar, ActorId = IdActorKateWinslet, Personaje = "Ronal" },
            new PeliculasActores
                { PeliculaId = IdPeliculaMisionImposible, ActorId = IdActorTomCruise, Personaje = "Ethan Hunt" },
            new PeliculasActores
                { PeliculaId = IdPeliculaMisionImposible, ActorId = IdActorHayleyAtwell, Personaje = "Grace" },
            new PeliculasActores
                { PeliculaId = IdPeliculaMarvels, ActorId = IdActorImanVellani, Personaje = "Kamala Khan" },
            new PeliculasActores
                { PeliculaId = IdPeliculaMarvels, ActorId = IdActorTeyonahParris, Personaje = "Monica Parris" },
            new PeliculasActores
                { PeliculaId = IdPeliculaMarvels, ActorId = IdActorBrieLarson, Personaje = "Carol Danvers" },
            new PeliculasActores
                { PeliculaId = IdPeliculaJoker, ActorId = IdActorJoaquinPhoenix, Personaje = "Arthur Fleck" },
            new PeliculasActores { PeliculaId = IdPeliculaJoker, ActorId = IdActorLadyGaga, Personaje = "Lee Quinzel" },
            new PeliculasActores
                { PeliculaId = IdPeliculaJoker, ActorId = IdActorZazieBeetz, Personaje = "Sophie Dumond" }
        );
    }

    private static void RellenarPeliculasCines(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeliculasCines>().HasData(
            new PeliculasCines { PeliculaId = IdPeliculaBabylon, CineId = IdCineRenoir },
            new PeliculasCines { PeliculaId = IdPeliculaBabylon, CineId = IdCineDiagonal },
            new PeliculasCines { PeliculaId = IdPeliculaHollywood, CineId = IdCineCallao },
            new PeliculasCines { PeliculaId = IdPeliculaAdAstra, CineId = IdCineDiagonal },
            new PeliculasCines { PeliculaId = IdPeliculaAdAstra, CineId = IdCineKinepolisValencia },
            new PeliculasCines { PeliculaId = IdPeliculaAdAstra, CineId = IdCineVerdi },
            new PeliculasCines { PeliculaId = IdPeliculaCiudadPerdida, CineId = IdCineKinepolisValencia },
            new PeliculasCines { PeliculaId = IdPeliculaWolves, CineId = IdCineYelmoIdeal },
            new PeliculasCines { PeliculaId = IdPeliculaDune, CineId = IdCineVerdi },
            new PeliculasCines { PeliculaId = IdPeliculaDune, CineId = IdCineCallao },
            new PeliculasCines { PeliculaId = IdPeliculaDune, CineId = IdCineDiagonal },
            new PeliculasCines { PeliculaId = IdPeliculaDune, CineId = IdCineRenoir },
            new PeliculasCines { PeliculaId = IdPeliculaAvatar, CineId = IdCineCallao },
            new PeliculasCines { PeliculaId = IdPeliculaMisionImposible, CineId = IdCineVerdi },
            new PeliculasCines { PeliculaId = IdPeliculaMarvels, CineId = IdCineDiagonal },
            new PeliculasCines { PeliculaId = IdPeliculaJoker, CineId = IdCineKinepolisValencia }
        );
    }

    private static void RellenarPeliculasGeneros(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PeliculasGeneros>().HasData(
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaBabylon },
            new PeliculasGeneros { GeneroId = IdGeneroComedia, PeliculaId = IdPeliculaBabylon },
            new PeliculasGeneros { GeneroId = IdGeneroHistorica, PeliculaId = IdPeliculaBabylon },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaHollywood },
            new PeliculasGeneros { GeneroId = IdGeneroComedia, PeliculaId = IdPeliculaHollywood },
            new PeliculasGeneros { GeneroId = IdGeneroCienciaFiccion, PeliculaId = IdPeliculaAdAstra },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaAdAstra },
            new PeliculasGeneros { GeneroId = IdGeneroAventura, PeliculaId = IdPeliculaCiudadPerdida },
            new PeliculasGeneros { GeneroId = IdGeneroComedia, PeliculaId = IdPeliculaCiudadPerdida },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaCiudadPerdida },
            new PeliculasGeneros { GeneroId = IdGeneroSuspense, PeliculaId = IdPeliculaWolves },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaWolves },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaDune },
            new PeliculasGeneros { GeneroId = IdGeneroAventura, PeliculaId = IdPeliculaDune },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaDune },
            new PeliculasGeneros { GeneroId = IdGeneroCienciaFiccion, PeliculaId = IdPeliculaAvatar },
            new PeliculasGeneros { GeneroId = IdGeneroFantasia, PeliculaId = IdPeliculaAvatar },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaMisionImposible },
            new PeliculasGeneros { GeneroId = IdGeneroEspionaje, PeliculaId = IdPeliculaMisionImposible },
            new PeliculasGeneros { GeneroId = IdGeneroAcción, PeliculaId = IdPeliculaMarvels },
            new PeliculasGeneros { GeneroId = IdGeneroAventura, PeliculaId = IdPeliculaMarvels },
            new PeliculasGeneros { GeneroId = IdGeneroCienciaFiccion, PeliculaId = IdPeliculaMarvels },
            new PeliculasGeneros { GeneroId = IdGeneroDrama, PeliculaId = IdPeliculaJoker },
            new PeliculasGeneros { GeneroId = IdGeneroCrimen, PeliculaId = IdPeliculaJoker },
            new PeliculasGeneros { GeneroId = IdGeneroThriller, PeliculaId = IdPeliculaJoker }
        );
    }

    private static void RellenarPeliculas(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pelicula>().HasData(
            new Pelicula(
                IdPeliculaBabylon,
                "Babylon",
                "Ambientada en Los Ángeles durante los años 20, cuenta una historia de ambición y excesos desmesurados que recorre la ascensión y caída de múltiples personajes durante una época de desenfrenada decadencia y depravación en los albores de Hollywood.",
                "https://www.youtube.com/watch?v=gBil8RpweBE&pp=ygUYYmFieWxvbiB0cmFpbGVyIGVzcGHDsW9s",
                true,
                new DateTime(2022, 12, 23),
                "https://localhost:7290/peliculas/ea9fd07a-1fb5-4eb7-a01a-1c27266c2309.png"
            ),
            new Pelicula
            (
                IdPeliculaHollywood,
                "Érase una vez en… Hollywood",
                "Hollywood, años 60. La estrella de un western televisivo, Rick Dalton (DiCaprio), intenta amoldarse a los cambios del medio al mismo tiempo que su doble (Pitt). La vida de Dalton está ligada completamente a Hollywood, y es vecino de la joven y prometedora actriz y modelo Sharon Tate (Robbie) que acaba de casarse con el prestigioso director Roman Polanski.",
                "https://www.youtube.com/watch?v=J0rFGJV3cYw",
                true,
                new DateTime(2019, 7, 26),
                "https://localhost:7290/peliculas/14a89f1e-d997-46ec-ae77-37b43118b00c.jpg"
            ),
            new Pelicula
            (
                IdPeliculaAdAstra,
                "Ad Astra",
                "El astronauta Roy McBride (Brad Pitt) viaja a los límites exteriores del sistema solar para encontrar a su padre perdido y desentrañar un misterio que amenaza la supervivencia de nuestro planeta. Su viaje desvelará secretos que desafían la naturaleza de la existencia humana y nuestro lugar en el cosmos.",
                "https://www.youtube.com/watch?v=2hy4clp3IMM",
                true,
                new DateTime(2019, 9, 20),
                "https://localhost:7290/peliculas/eecfa05e-7968-474a-93c4-3f5b24e5cb66.jpg"
            ),
            new Pelicula
            (
                IdPeliculaCiudadPerdida,
                "La ciudad perdida",
                "La carrera literaria de la brillante y algo huraña escritora de novelas Loretta Sage (Sandra Bullock) ha girado en torno a las novelas románticas de aventuras que, ambientadas en lugares exóticos, protagoniza un atractivo galán cuya imagen aparece reproducida en todas las portadas, y que en la vida real corresponde a Alan (Channing Tatum), un modelo que ha centrado su carrera en personificar al novelesco aventurero. Durante una gira para promocionar su nuevo libro junto a Alan, Loretta es raptada por un excéntrico multimillonario (Daniel Radcliffe), con la intención de que la autora le guíe hasta el tesoro de la antigua ciudad perdida sobre el que gira su último relato. Deseoso de demostrar que puede ser un héroe en la vida real, y no simplemente en las páginas de sus obras de ficción, Alan se lanza al rescate de la novelista.",
                "https://www.youtube.com/watch?v=DWq5cjkxEQQ",
                true,
                new DateTime(2022, 3, 25),
                "https://localhost:7290/peliculas/0acee9d1-94df-4229-aab0-bf7c308e2933.jpg"
            ),
            new Pelicula
            (
                IdPeliculaWolves,
                "Wolves",
                "Dos solitarios se ven involucrados en el mismo trabajo, que pronto se convierte en una carrera por la supervivencia.",
                "https://www.youtube.com/watch?v=Ti_7suoHmRQ",
                false,
                new DateTime(2025, 6, 15),
                string.Empty
            ),
            new Pelicula
            (
                IdPeliculaDune,
                "Dune: Parte dos",
                "Tras los sucesos de la primera parte acontecidos en el planeta Arrakis, el joven Paul Atreides se une a la tribu de los Fremen y comienza un viaje espiritual y marcial para convertirse en mesías, mientras intenta evitar el horrible pero inevitable futuro que ha presenciado: una Guerra Santa en su nombre, que se extiende por todo el universo conocido... Secuela de 'Dune' (2021).",
                "https://www.youtube.com/watch?v=6OmJF6VjKMA",
                true,
                new DateTime(2024, 3, 15),
                "https://localhost:7290/peliculas/98e8356c-3214-454f-b6c5-81f82de778ff.jpg"
            ),
            new Pelicula
            (
                IdPeliculaAvatar,
                "Avatar 3",
                "La tercera entrega de la saga \"Avatar\", presenta al Pueblo de las Cenizas, un clan Na'vi no tan pacífico que utilizará la violencia si lo necesita para conseguir sus objetivos, aunque sea contra otros clanes.",
                "https://www.youtube.com/watch?v=YXtWPVFk5TQ",
                false,
                new DateTime(2025, 12, 19),
                "https://localhost:7290/peliculas/aad70b69-1dd1-4b5a-8e4a-1941c00fe96f.jpg"
            ),
            new Pelicula
            (
                IdPeliculaMisionImposible,
                "Misión: Imposible - Sentencia Mortal Parte Dos",
                "Ethan Hunt continúa su lucha contra una nueva amenaza global en la segunda parte de esta entrega de alta tensión y acción.",
                "https://www.youtube.com/watch?v=8jRMVhGwy0M",
                true,
                new DateTime(2024, 6, 28),
                "https://localhost:7290/peliculas/ec9ebb58-73f3-4a0e-ae57-2e7de11da751.jpg"
            ),
            new Pelicula
            (
                IdPeliculaMarvels,
                "The Marvels",
                "Carol Danvers, alias Capitana Marvel, ha recuperado la identidad que le arrebataron los tiránicos Kree y se ha cobrado su venganza contra la Inteligencia Suprema. Pero una serie de consecuencias imprevistas la obligan a cargar con el peso de un universo desestabilizado. Cuando el deber la lleva hasta un anómalo agujero de gusano vinculado a una revolucionaria Kree, sus poderes se conectan con los de su superfán de Nueva Jersey Kamala Khan, también conocida como Ms. Marvel, y con los de su sobrina, con la que está distanciada y es ahora astronauta en S.A.B.E.R., la capitana Monica Rambeau. Juntas, las integrantes de este insólito trío tendrán que unir fuerzas y aprender a trabajar en equipo como 'The Marvels' para salvar el universo.",
                "https://www.youtube.com/watch?v=gdSGIf8kbhg",
                true,
                new DateTime(2024, 11, 8),
                "https://localhost:7290/peliculas/c2eb8dbc-9a1f-4bbe-a8d5-346999a51022.jpg"
            ),
            new Pelicula
            (
                IdPeliculaJoker,
                "Joker: locura de a dos",
                "Tras crear el caos, Arthur Fleck ha sido internado en Arkham a la espera de juicio por sus crímenes como Joker. Mientras lidia con su doble identidad, Arthur no sólo se topa con el amor verdadero, sino que también descubre la música que siempre ha estado dentro de él. Secuela de 'Joker' (2019).",
                "https://www.youtube.com/watch?v=7SZfThvjt5I",
                true,
                new DateTime(2024, 10, 4),
                "https://localhost:7290/peliculas/c900cffe-1828-46f1-9893-99b86ec064ab.png"
            )
        );
    }

    private static void RellenarActores(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasData(
            new Actor(
                IdActorLeonardo,
                "Leonardo DiCaprio",
                "Leonardo DiCaprio es un actor y productor estadounidense conocido por películas como 'Titanic', 'Inception' y 'The Revenant'. Ganó un Óscar por 'The Revenant'.",
                new DateTime(1974, 11, 11),
                "https://localhost:7290/actores/39c562aa-c83d-4bc7-97aa-8895dc46880c.jpg"),
            new Actor
            (
                IdActorMerylStreep,
                "Meryl Streep",
                "Meryl Streep es una reconocida actriz estadounidense, famosa por su habilidad para interpretar distintos personajes. Ha ganado tres premios Óscar y es una de las actrices más nominadas en la historia del cine.",
                new DateTime(1949, 6, 22),
                "https://localhost:7290/actores/ade14658-7f47-496a-ace0-7c1d0414f468.jpg"
            ),
            new Actor(
                IdActorRobertDeNiro,
                "Robert De Niro",
                "Robert De Niro es un actor y productor estadounidense, famoso por sus papeles en 'Taxi Driver', 'Raging Bull' y 'Goodfellas'. Ha ganado dos premios Óscar.",
                new DateTime(1943, 8, 17),
                "https://localhost:7290/actores/b0ff03ae-86fa-426b-9ce2-9e4975678026.jpg"
            ),
            new Actor
            (
                IdActorScarlettJohansson,
                "Scarlett Johansson",
                "Scarlett Johansson es una actriz estadounidense conocida por su papel en el Universo Cinematográfico de Marvel como 'Black Widow' y en películas como 'Lost in Translation'.",
                new DateTime(1984, 11, 22),
                "https://localhost:7290/actores/ef905ad6-7cb3-46d9-adfc-e2961efd0437.jpg"
            ),
            new Actor
            (
                IdActorTomHanks,
                "Tom Hanks",
                "Tom Hanks es un actor y productor estadounidense conocido por sus papeles en 'Forrest Gump', 'Saving Private Ryan' y 'Cast Away'. Ha ganado dos premios Óscar consecutivos.",
                new DateTime(1956, 7, 9),
                "https://localhost:7290/actores/91510ed1-a7dd-4592-bbc4-e3baa12285c0.jpg"
            ),
            new Actor
            (
                IdActorNataliePortman,
                "Natalie Portman",
                "Natalie Portman es una actriz y productora estadounidense-israelí, conocida por su papel en 'Black Swan', por el que ganó un Óscar, y su participación en la saga 'Star Wars'.",
                new DateTime(1981, 6, 9),
                "https://localhost:7290/actores/3531dfef-80bd-4e62-b40b-d7f5e89ddb27.jpg"
            ),
            new Actor
            (
                IdActorBradPitt,
                "Brad Pitt",
                "Brad Pitt es un actor y productor estadounidense famoso por sus papeles en 'Fight Club', 'Inglourious Basterds' y 'Once Upon a Time in Hollywood', por el que ganó un Óscar.",
                new DateTime(1963, 12, 18),
                "https://localhost:7290/actores/fed532b0-86d5-4e3d-9978-cbaf00f53bd2.jpg"
            ),
            new Actor
            (
                IdActorEmmaStone,
                "Emma Stone",
                "Emma Stone es una actriz estadounidense conocida por su papel en 'La La Land', por el cual ganó un Óscar. También es conocida por su trabajo en 'Easy A' y 'The Amazing Spider-Man'.",
                new DateTime(1988, 11, 6),
                "https://localhost:7290/actores/626b3111-fd53-40f9-a88c-02dcc38587a2.jpg"
            ),
            new Actor
            (
                IdActorMorganFreeman,
                "Morgan Freeman",
                "Morgan Freeman es un actor y narrador estadounidense conocido por su voz distintiva y papeles en 'The Shawshank Redemption', 'Se7en' y 'Driving Miss Daisy'. Ganó un Óscar en 2005.",
                new DateTime(1937, 6, 1),
                "https://localhost:7290/actores/76ac4765-8bcd-4075-8bf2-25c601e0a891.jpeg"
            ),
            new Actor
            (
                IdActorCharlizeTheron,
                "Charlize Theron",
                "Charlize Theron es una actriz y productora sudafricana conocida por su papel en 'Monster', por el que ganó un Óscar, y su actuación en películas de acción como 'Mad Max: Fury Road'.",
                new DateTime(1975, 8, 7),
                "https://localhost:7290/actores/620ba7f7-38ac-4727-9a7c-8f3f7dcfb47e.jpg"
            ),
            new Actor
            (
                IdActorMargot,
                "Margot Robbie",
                "Margot Robbie es una actriz y productora australiana conocida por sus papeles en películas como 'The Wolf of Wall Street', 'I, Tonya' y 'Barbie'. Ha sido nominada a varios premios, incluyendo el Óscar, y es reconocida por su versatilidad en papeles dramáticos y cómicos.",
                new DateTime(1990, 7, 2),
                "https://localhost:7290/actores/8FA42CB3-2A52-4C12-A5D6-EED127CA6139.jpg"
            ),
            new Actor
            (
                IdActorRuth,
                "Ruth Negga",
                "Ruth Negga es una actriz irlandesa-etíope conocida por su actuación en 'Loving', por la que recibió una nominación al Óscar. También ha destacado en series como 'Preacher' y 'Agents of S.H.I.E.L.D.'.",
                new DateTime(1981, 1, 7),
                "https://localhost:7290/actores/50D498BD-39F2-42C5-A6B8-781DA33CB01D.jpg"
            ),
            new Actor
            (
                IdActorTommy,
                "Tommy Lee Jones",
                "Tommy Lee Jones es un actor y director estadounidense ganador del Óscar, conocido por papeles en películas como 'Men in Black', 'No Country for Old Men' y 'The Fugitive'. Es reconocido por su carácter y estilo distintivo en la pantalla.",
                new DateTime(1946, 9, 15),
                "https://localhost:7290/actores/01CF2324-A586-4A1E-9583-C4A35FFDA084.jpg"
            ),
            new Actor
            (
                IdActorSandra,
                "Sandra Bullock",
                "Sandra Bullock es una actriz y productora estadounidense, conocida por su versatilidad en una amplia gama de géneros, desde la comedia en 'Miss Congeniality' hasta el drama en 'The Blind Side', película que le valió un Óscar. También ha sido aclamada por sus papeles en 'Gravity' y 'Bird Box'.",
                new DateTime(1964, 7, 26),
                "https://localhost:7290/actores/9F0150C5-6584-45D0-9EFC-9E0F78B49BAF.jpg"
            ),
            new Actor
            (
                IdActorChanning,
                "Channing Tatum",
                "Channing Tatum es un actor, productor y bailarín estadounidense, conocido por sus papeles en películas como 'Magic Mike', 'Step Up' y '21 Jump Street'. Su habilidad para la danza le ha ayudado a destacarse, además de su presencia en comedias y dramas.",
                new DateTime(1980, 4, 26),
                "https://localhost:7290/actores/ED6F7AB2-28AB-4AA1-8F0B-F988B4594D5F.jpg"
            ),
            new Actor
            (
                IdActorGeorge,
                "George Clooney",
                "George Clooney es un actor, director y productor estadounidense, reconocido mundialmente por su trabajo en películas como 'Ocean's Eleven', 'Gravity', 'The Descendants' y 'Up in the Air'. Ha ganado múltiples premios, incluidos los premios Óscar, y es conocido por su activismo y trabajo humanitario.",
                new DateTime(1961, 5, 6),
                "https://localhost:7290/actores/74E76C1E-EC0E-4AB2-BA80-A83CE2385235.jpg"
            ),
            new Actor
            (
                IdActorTimothee,
                "Timothée Chalamet",
                "Timothée Chalamet es un actor estadounidense, conocido por sus papeles en 'Call Me by Your Name', 'Little Women', y su participación en 'Dune'. Aclamado por su habilidad actoral, Chalamet ha sido nominado a varios premios importantes, incluidos los premios Óscar.",
                new DateTime(1995, 12, 27),
                "https://localhost:7290/actores/B5F73E68-8140-4904-9D25-C764CECD0199.jpg"
            ),
            new Actor
            (
                IdActorZendaya,
                "Zendaya",
                "Zendaya Maree Stoermer Coleman, conocida profesionalmente como Zendaya, es una actriz y cantante estadounidense famosa por su papel en la serie de Disney Channel 'Shake It Up' y su papel en películas como 'Spider-Man: Homecoming' y 'Dune'. Además de su carrera en la actuación, Zendaya es una influyente figura en la moda y activismo social.",
                new DateTime(1996, 9, 1),
                "https://localhost:7290/actores/5D506761-8211-4C40-A4AB-CCC2582A335C.jpg"
            ),
            new Actor
            (
                IdActorKateWinslet,
                "Kate Winslet",
                "Kate Winslet es una actriz inglesa ganadora de múltiples premios, incluyendo un Óscar por su papel en 'The Reader'. Es conocida por su capacidad de adaptarse a roles diversos, como en 'Titanic', 'Eternal Sunshine of the Spotless Mind', y en la saga de Avatar como la Dr. Ronal.",
                new DateTime(1975, 10, 5),
                "https://localhost:7290/actores/A77A6BEA-0FDD-49BE-83DB-93F6B81BEAC3.jpg"
            ),
            new Actor
            (
                IdActorCliffCurtis,
                "Cliff Curtis",
                "Cliff Curtis es un actor neozelandés conocido por sus roles en películas de acción y dramas. Ha trabajado en varias producciones importantes, incluyendo 'Training Day', 'The Dark Horse', y 'Avatar'. En la saga de Avatar, interpreta a Tonowari, el líder de la tribu de los Metkayina.",
                new DateTime(1968, 7, 27),
                "https://localhost:7290/actores/FC2B363B-0FBE-44A3-94FD-9D08E5C72C51.jpg"
            ),
            new Actor
            (
                IdActorTomCruise,
                "Tom Cruise",
                "Tom Cruise es uno de los actores más famosos y exitosos de Hollywood, conocido por su papel icónico como Ethan Hunt en la saga 'Misión: Imposible'. Además de ser un actor destacado, ha sido productor de muchas de sus películas y es conocido por sus impresionantes acrobacias y dedicación a sus roles.",
                new DateTime(1962, 7, 3),
                "https://localhost:7290/actores/7671EC80-98D6-403A-AEC7-4C8A3A7DE2E7.jpg"
            ),
            new Actor
            (
                IdActorHayleyAtwell,
                "Hayley Atwell",
                "Hayley Atwell es una actriz británica conocida por su papel de Peggy Carter en el Universo Cinematográfico de Marvel. Su presencia en 'Misión: Imposible - Sentencia Mortal Parte Dos' marca una nueva colaboración en el cine de acción, donde interpreta a un personaje clave dentro de la trama.",
                new DateTime(1982, 4, 5),
                "https://localhost:7290/actores/E4E6F0A2-BDEA-44C4-956A-D86E02CCFA45.jpg"
            ),
            new Actor
            (
                IdActorBrieLarson,
                "Brie Larson",
                "Brie Larson es una actriz, directora y productora estadounidense conocida por su papel como Carol Danvers/Captain Marvel en el Universo Cinematográfico de Marvel. Ganó el Premio de la Academia a la Mejor Actriz por su actuación en 'Room'. Además de su carrera actoral, Larson también ha incursionado en la dirección de películas.",
                new DateTime(1989, 10, 1),
                "https://localhost:7290/actores/54CEFD17-5189-46EE-81B1-AC93F0A42CAB.jpg"
            ),
            new Actor
            (
                IdActorTeyonahParris,
                "Teyonah Parris",
                "Teyonah Parris es una actriz estadounidense conocida por su papel como Monica Rambeau en la serie de Disney+ 'WandaVision' y ahora en 'The Marvels'. Parris ha sido aclamada por su trabajo en la televisión y el cine, destacándose por su versatilidad y talento.",
                new DateTime(1987, 9, 22),
                "https://localhost:7290/actores/CC6C7B1C-BED7-434A-8F39-404077C11F5F.jpg"
            ),
            new Actor
            (
                IdActorImanVellani,
                "Iman Vellani",
                "Iman Vellani es una joven actriz canadiense conocida por interpretar a Kamala Khan/Ms. Marvel en la serie de Disney+ 'Ms. Marvel'. 'The Marvels' es su participación en el Universo Cinematográfico de Marvel, donde compartirá pantalla con otras heroínas del MCU.",
                new DateTime(2002, 9, 3),
                "https://localhost:7290/actores/DFD1D3B8-EE44-4B63-A335-B16CE508C80A.jpg"
            ),
            new Actor
            (
                IdActorLadyGaga,
                "Lady Gaga",
                "Lady Gaga es una cantante, compositora y actriz estadounidense, conocida por su estilo musical ecléctico y su presencia en el escenario. Ha ganado múltiples premios, incluidos varios premios Grammy, y su actuación en 'A Star Is Born' (2018) le valió una nominación al Óscar. En 'Joker: Locura de a Dos', interpretará a Harley Quinn.",
                new DateTime(1986, 3, 28),
                "https://localhost:7290/actores/DD1BAEBB-57E2-4D97-834E-79503110E782.jpg"
            ),
            new Actor
            (
                IdActorZazieBeetz,
                "Zazie Beetz",
                "Zazie Beetz es una actriz alemana-estadounidense conocida por sus papeles en 'Atlanta', 'Deadpool 2' y 'Joker'. En 'Joker', interpretó a Sophie Dumond, un personaje central que tiene una conexión crucial con Arthur Fleck/Joker. Beetz ha sido elogiada por su talento y versatilidad.",
                new DateTime(1991, 6, 25),
                "https://localhost:7290/actores/757387BF-FA8B-40DA-8F34-BC9156071FFD.jpg"
            ),
            new Actor
            (
                IdActorJoaquinPhoenix,
                "Joaquin Phoenix",
                "Joaquin Phoenix es un actor, productor y activista estadounidense, conocido por sus papeles en películas como 'Gladiator', 'Her' y 'The Master'. Su interpretación del Joker en la película 'Joker' (2019) le valió el Premio Óscar a Mejor Actor, convirtiéndose en uno de los actores más aclamados de su generación.",
                new DateTime(1974, 10, 28),
                "https://localhost:7290/actores/7A3B28F1-2CDD-4F5D-9F57-DCD64C2B63A3.jpg"
            ),
            new Actor
            (
                IdActorLucasTill,
                "Lucas Till",
                "Lucas Till es un actor estadounidense conocido por sus papeles en 'X-Men: First Class' (2011) como Havok, y por protagonizar la serie de televisión 'MacGyver' (2016-2021) como Angus MacGyver. También ha trabajado en películas como 'Battle: Los Angeles' (2011) y 'The Disappointments Room' (2016).",
                new DateTime(1990, 8, 10),
                "https://localhost:7290/actores/BE15B21C-AE30-4E8D-A4B8-DCD28C027000.jpg"
            ),
            new Actor
            (
                IdActorJasonMomoa,
                "Jason Momoa",
                "Jason Momoa es un actor, productor y director estadounidense conocido por sus papeles en la serie de televisión 'Game of Thrones' como Khal Drogo, y como el superhéroe Aquaman en el universo cinematográfico de DC. También ha trabajado en otras producciones como 'Frontier', 'The Red Road' y 'See'. Su presencia en pantalla y su carisma lo han convertido en uno de los actores más populares de la actualidad.",
                new DateTime(1979, 8, 1),
                "https://localhost:7290/actores/4DACD85F-6223-4AF4-B146-C8115958ED90.jpg"
            )
        );
    }

    private static void RellenarGeneros(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genero>().HasData(
            new Genero { Id = IdGeneroAcción, Nombre = "Acción" },
            new Genero { Id = IdGeneroAventura, Nombre = "Aventura" },
            new Genero { Id = IdGeneroCatástrofe, Nombre = "Catástrofe" },
            new Genero { Id = IdGeneroCienciaFiccion, Nombre = "Ciencia Ficción" },
            new Genero { Id = IdGeneroComedia, Nombre = "Comedia" },
            new Genero { Id = IdGeneroDocumentales, Nombre = "Documentales" },
            new Genero { Id = IdGeneroDrama, Nombre = "Drama" },
            new Genero { Id = IdGeneroFantasia, Nombre = "Fantasia" },
            new Genero { Id = IdGeneroTerror, Nombre = "Terror" },
            new Genero { Id = IdGeneroRomantico, Nombre = "Romantico" },
            new Genero { Id = IdGeneroHistorica, Nombre = "Historica" },
            new Genero { Id = IdGeneroSuspense, Nombre = "Suspense" },
            new Genero { Id = IdGeneroEspionaje, Nombre = "Espionaje" },
            new Genero { Id = IdGeneroCrimen, Nombre = "Crimen" },
            new Genero { Id = IdGeneroThriller, Nombre = "Thriller" });
    }

    private static void RellenarCines(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cine>().HasData(
            new Cine(IdCineCallao, "Cines Callao", new Point(-3.705912, 40.419829)),
            new Cine(IdCineYelmoIdeal, "Yelmo Cines Ideal", new Point(-3.7065112, 40.41357)),
            new Cine(IdCineDiagonal, "Cinesa Diagonal Mar", new Point(2.2140153, 41.4096507)),
            new Cine(IdCineRenoir, "Cines Renoir Plaza de España", new Point(-3.7159609, 40.4243981)),
            new Cine(IdCineVerdi, "Cines Verdi Barcelona", new Point(2.1542843, 41.4039621)),
            new Cine(IdCineGranollers, "Ocine Granollers", new Point(2.2866108, 41.6067659)),
            new Cine(IdCineKinepolisValencia, "Kinépolis Valencia", new Point(-0.4287164, 39.4778583))
        );
    }
}