using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 3, "The Legend of Zelda: Ocarina of Time[a] é um jogo eletrônico de ação e aventura desenvolvido e publicado pela Nintendo para o Nintendo 64. Foi lançado no Japão e na América do Norte em novembro de 1998 e nas regiões PAL no mês seguinte. Ocarina of Time é o primeiro jogo da série The Legend of Zelda com gráficos 3D.", "https://upload.wikimedia.org/wikipedia/pt/thumb/1/17/The_Legend_of_Zelda_Ocarina_of_Time_capa.png/280px-The_Legend_of_Zelda_Ocarina_of_Time_capa.png", 15.99m, "The Legend of Zelda: Ocarina of Time" },
                    { 5, 3, "The Legend of Zelda: Majora's Mask (ゼルダの伝説: ムジュラの仮面 Zeruda no Densetsu: Mujura no Kamen?) é um jogo eletrônico de ação-aventura desenvolvido e publicado pela Nintendo para o console Nintendo 64. Ele foi lançado mundialmente em 2000 como o sexto jogo da série The Legend of Zelda e o segundo a empregar gráficos em 3D depois de The Legend of Zelda: Ocarina of Time de 1998, do qual ele é uma sequência direta. ", "https://upload.wikimedia.org/wikipedia/pt/thumb/3/35/The_Legend_of_Zelda_Majora%27s_Mask_capa.png/280px-The_Legend_of_Zelda_Majora%27s_Mask_capa.png", 16.99m, "The Legend of Zelda: Majora's Mask" },
                    { 6, 3, "The Legend of Zelda: The Wind Waker (ゼルダの伝説 風のタクト Zeruda no Densetsu: Kaze no Takuto?) é um jogo eletrônico de ação-aventura desenvolvido pela Nintendo Entertainment Analysis & Development e publicado pela Nintendo. É o décimo título da série The Legend of Zelda e foi lançado exclusivamente para GameCube em dezembro de 2002 no Japão, março de 2003 na América do Norte e maio na Europa.", "https://upload.wikimedia.org/wikipedia/pt/thumb/0/06/The_Legend_of_Zelda_The_Wind_Waker_capa.png/270px-The_Legend_of_Zelda_The_Wind_Waker_capa.png", 14.99m, "The Legend of Zelda: The Wind Waker" },
                    { 7, 2, "The Wolf of Wall Street (bra/prt: O Lobo de Wall Street)[3][4] é um filme estadunidense de 2013, do gênero comédia dramático-biográfico-policial, dirigido por Martin Scorsese, com roteiro de Terence Winter baseado nas memórias de Jordan Belfort, The Wolf of Wall Street.[5]", "https://upload.wikimedia.org/wikipedia/pt/thumb/8/8d/The_Wolf_of_Wall_Street.jpg/250px-The_Wolf_of_Wall_Street.jpg", 7.99m, "O Lobo de Wall Street" },
                    { 8, 2, "Interstellar (no Brasil, Interestelar) é um filme anglo-americano de ficção científica dirigido por Christopher Nolan e estrelado por Matthew McConaughey, Anne Hathaway, Jessica Chastain, Bill Irwin, Mackenzie Foy, Matt Damon, John Lithgow e Michael Caine. Ele conta a história de uma equipe de astronautas que viaja através de um buraco de minhoca à procura de um novo lar para a humanidade. ", "https://upload.wikimedia.org/wikipedia/pt/thumb/3/3a/Interstellar_Filme.png/250px-Interstellar_Filme.png", 9.99m, "Interstellar" },
                    { 9, 2, "Donnie (Jake Gyllenhaal) é um inteligente jovem de classe média, porém antissocial. Ele tem visões de um coelho monstruoso que o convence a fazer brincadeiras humilhantes com seus colegas. Numa dessas visões, o coelho anuncia o fim do mundo em um mês, e eventos terríveis começam a assombrá-lo.", "https://upload.wikimedia.org/wikipedia/pt/thumb/5/58/Donnie_Darko.jpg/220px-Donnie_Darko.jpg", 8.99m, "Donnie Darko" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
