#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Peliculas.API.Infraestructura.Migrations
{
    /// <inheritdoc />
    public partial class DatosSinopsis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resumen",
                value: "Ambientada en Los Ángeles durante los años 20, cuenta una historia de ambición y excesos desmesurados que recorre la ascensión y caída de múltiples personajes durante una época de desenfrenada decadencia y depravación en los albores de Hollywood.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resumen",
                value: "Hollywood, años 60. La estrella de un western televisivo, Rick Dalton (DiCaprio), intenta amoldarse a los cambios del medio al mismo tiempo que su doble (Pitt). La vida de Dalton está ligada completamente a Hollywood, y es vecino de la joven y prometedora actriz y modelo Sharon Tate (Robbie) que acaba de casarse con el prestigioso director Roman Polanski.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resumen",
                value: "El astronauta Roy McBride (Brad Pitt) viaja a los límites exteriores del sistema solar para encontrar a su padre perdido y desentrañar un misterio que amenaza la supervivencia de nuestro planeta. Su viaje desvelará secretos que desafían la naturaleza de la existencia humana y nuestro lugar en el cosmos.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resumen",
                value: "La carrera literaria de la brillante y algo huraña escritora de novelas Loretta Sage (Sandra Bullock) ha girado en torno a las novelas románticas de aventuras que, ambientadas en lugares exóticos, protagoniza un atractivo galán cuya imagen aparece reproducida en todas las portadas, y que en la vida real corresponde a Alan (Channing Tatum), un modelo que ha centrado su carrera en personificar al novelesco aventurero. Durante una gira para promocionar su nuevo libro junto a Alan, Loretta es raptada por un excéntrico multimillonario (Daniel Radcliffe), con la intención de que la autora le guíe hasta el tesoro de la antigua ciudad perdida sobre el que gira su último relato. Deseoso de demostrar que puede ser un héroe en la vida real, y no simplemente en las páginas de sus obras de ficción, Alan se lanza al rescate de la novelista.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resumen",
                value: "Tras los sucesos de la primera parte acontecidos en el planeta Arrakis, el joven Paul Atreides se une a la tribu de los Fremen y comienza un viaje espiritual y marcial para convertirse en mesías, mientras intenta evitar el horrible pero inevitable futuro que ha presenciado: una Guerra Santa en su nombre, que se extiende por todo el universo conocido... Secuela de 'Dune' (2021).");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Resumen",
                value: "La tercera entrega de la saga \"Avatar\", presenta al Pueblo de las Cenizas, un clan Na'vi no tan pacífico que utilizará la violencia si lo necesita para conseguir sus objetivos, aunque sea contra otros clanes.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Resumen",
                value: "Carol Danvers, alias Capitana Marvel, ha recuperado la identidad que le arrebataron los tiránicos Kree y se ha cobrado su venganza contra la Inteligencia Suprema. Pero una serie de consecuencias imprevistas la obligan a cargar con el peso de un universo desestabilizado. Cuando el deber la lleva hasta un anómalo agujero de gusano vinculado a una revolucionaria Kree, sus poderes se conectan con los de su superfán de Nueva Jersey Kamala Khan, también conocida como Ms. Marvel, y con los de su sobrina, con la que está distanciada y es ahora astronauta en S.A.B.E.R., la capitana Monica Rambeau. Juntas, las integrantes de este insólito trío tendrán que unir fuerzas y aprender a trabajar en equipo como 'The Marvels' para salvar el universo.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Resumen",
                value: "Tras crear el caos, Arthur Fleck ha sido internado en Arkham a la espera de juicio por sus crímenes como Joker. Mientras lidia con su doble identidad, Arthur no sólo se topa con el amor verdadero, sino que también descubre la música que siempre ha estado dentro de él. Secuela de 'Joker' (2019).");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Resumen",
                value: "Una épica historia sobre el exceso, la decadencia y los sueños rotos en el Hollywood de los años 20, donde la transición del cine mudo al sonoro sacude a la industria.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Resumen",
                value: "Un actor de televisión y su doble de riesgo se encuentran con los eventos de 1969 en Hollywood mientras las estrellas de cine se enfrentan a un cambio cultural.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Resumen",
                value: "Un astronauta viaja a los rincones más distantes del sistema solar para encontrar a su padre y resolver un misterio que amenaza la supervivencia de la Tierra.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Resumen",
                value: "Una escritora de novelas románticas es secuestrada por un millonario que busca un tesoro perdido en una isla remota, y es rescatada por su modelo de portada.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 6,
                column: "Resumen",
                value: "La segunda parte de la épica adaptación de Dune, donde Paul Atreides busca venganza y un legado que cambiará el universo.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 7,
                column: "Resumen",
                value: "La siguiente entrega de la saga de ciencia ficción de Pandora, explorando nuevas regiones del planeta y enfrentándose a amenazas desconocidas.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 9,
                column: "Resumen",
                value: "Las heroínas del universo Marvel, Carol Danvers, Kamala Khan y Monica Rambeau, unen fuerzas para enfrentar una amenaza cósmica.");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "Id",
                keyValue: 10,
                column: "Resumen",
                value: "Arthur Fleck regresa como el Joker en una secuela que explora su relación con Harley Quinn y el oscuro descenso de ambos.");
        }
    }
}
