namespace BEcommerce.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductVariant>()
            .HasKey(p => new { p.ProductId, p.ProductTypeId });

        modelBuilder.Entity<ProductType>().HasData(
            new ProductType { Id = 1, Name = "Default" },
            new ProductType { Id = 2, Name = "Paperback" },
            new ProductType { Id = 3, Name = "E-Book" },
            new ProductType { Id = 4, Name = "Audiobook" },
            new ProductType { Id = 5, Name = "Stream" },
            new ProductType { Id = 6, Name = "Blu-ray" },
            new ProductType { Id = 7, Name = "VHS" },
            new ProductType { Id = 8, Name = "PC" },
            new ProductType { Id = 9, Name = "PlayStation" },
            new ProductType { Id = 10, Name = "Xbox" },
            new ProductType { Id = 11, Name = "Nintendo64" },
            new ProductType { Id = 12, Name = "GameBoy" }
        );
            
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Books",
                Url = "books"
            },
            new Category
            {
                Id = 2,
                Name = "Movies",
                Url = "movies"
            },
            new Category
            {
                Id = 3,
                Name = "Games",
                Url = "games"
            },
            new Category
            {
                Id = 4,
                Name = "Consoles",
                Url = "consoles"
            }
        );
        
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "The Fellowship of the Ring",
                Description = "The Fellowship of the Ring is the first of three volumes of the epic novel[2] The Lord of the Rings by the English author J. R. R. Tolkien. It is followed by The Two Towers and The Return of the King. The action takes place in the fictional universe of Middle-earth. The book was first published on 29 July 1954 in the United Kingdom. The volume consists of a foreword, in which the author discusses his writing of The Lord of the Rings, a prologue titled \"Concerning Hobbits, and other matters\", and the main narrative in Book I and Book II.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8e/The_Fellowship_of_the_Ring_cover.gif",
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Title = "The Two Towers",
                Description = "The Two Towers is the second volume of J. R. R. Tolkien's high fantasy novel The Lord of the Rings. It is preceded by The Fellowship of the Ring and followed by The Return of the King. The volume's title is ambiguous, as five towers are named in the narrative, and Tolkien himself gave conflicting identifications of the two towers. The narrative is interlaced, allowing Tolkien to build in suspense and surprise. The volume was largely welcomed by critics, who found it exciting and compelling, combining epic narrative with heroic romance.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a1/The_Two_Towers_cover.gif",
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Title = "The Return of the King",
                Description = "The Return of the King is the third and final volume of J. R. R. Tolkien's The Lord of the Rings, following The Fellowship of the Ring and The Two Towers. It was published in 1955. The story begins in the kingdom of Gondor, which is soon to be attacked by the Dark Lord Sauron.\n\nThe volume was praised by literary figures including W. H. Auden, Anthony Price, and Michael Straight, but attacked by Edwin Muir who had praised The Fellowship of the Ring.\n\nThe chapter \"The Scouring of the Shire\", and a chapter-length narrative in the appendices, \"The Tale of Aragorn and Arwen\", have attracted discussion by scholars and critics.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/11/The_Return_of_the_King_cover.gif",
                CategoryId = 1
            },
            new Product
            {
                Id = 4,
                Title = "The Legend of Zelda: Ocarina of Time",
                Description = "The Legend of Zelda: Ocarina of Time[a] é um jogo eletrônico de ação e aventura desenvolvido e publicado pela Nintendo para o Nintendo 64. Foi lançado no Japão e na América do Norte em novembro de 1998 e nas regiões PAL no mês seguinte. Ocarina of Time é o primeiro jogo da série The Legend of Zelda com gráficos 3D.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/1/17/The_Legend_of_Zelda_Ocarina_of_Time_capa.png/280px-The_Legend_of_Zelda_Ocarina_of_Time_capa.png",
                CategoryId = 3
            },
            new Product
            {
                Id = 5,
                Title = "The Legend of Zelda: Majora's Mask",
                Description = "The Legend of Zelda: Majora's Mask (ゼルダの伝説: ムジュラの仮面 Zeruda no Densetsu: Mujura no Kamen?) é um jogo eletrônico de ação-aventura desenvolvido e publicado pela Nintendo para o console Nintendo 64. Ele foi lançado mundialmente em 2000 como o sexto jogo da série The Legend of Zelda e o segundo a empregar gráficos em 3D depois de The Legend of Zelda: Ocarina of Time de 1998, do qual ele é uma sequência direta. ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/3/35/The_Legend_of_Zelda_Majora%27s_Mask_capa.png/280px-The_Legend_of_Zelda_Majora%27s_Mask_capa.png",
                CategoryId = 3
            },
            new Product
            {
                Id = 6,
                Title = "The Legend of Zelda: The Wind Waker",
                Description = "The Legend of Zelda: The Wind Waker (ゼルダの伝説 風のタクト Zeruda no Densetsu: Kaze no Takuto?) é um jogo eletrônico de ação-aventura desenvolvido pela Nintendo Entertainment Analysis & Development e publicado pela Nintendo. É o décimo título da série The Legend of Zelda e foi lançado exclusivamente para GameCube em dezembro de 2002 no Japão, março de 2003 na América do Norte e maio na Europa.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/0/06/The_Legend_of_Zelda_The_Wind_Waker_capa.png/270px-The_Legend_of_Zelda_The_Wind_Waker_capa.png",
                CategoryId = 3
            },
            new Product
            {
                Id = 7,
                Title = "O Lobo de Wall Street",
                Description = "The Wolf of Wall Street (bra/prt: O Lobo de Wall Street)[3][4] é um filme estadunidense de 2013, do gênero comédia dramático-biográfico-policial, dirigido por Martin Scorsese, com roteiro de Terence Winter baseado nas memórias de Jordan Belfort, The Wolf of Wall Street.[5]",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/8/8d/The_Wolf_of_Wall_Street.jpg/250px-The_Wolf_of_Wall_Street.jpg",
                CategoryId = 2
            },
            new Product
            {
                Id = 8,
                Title = "Interstellar",
                Description = "Interstellar (no Brasil, Interestelar) é um filme anglo-americano de ficção científica dirigido por Christopher Nolan e estrelado por Matthew McConaughey, Anne Hathaway, Jessica Chastain, Bill Irwin, Mackenzie Foy, Matt Damon, John Lithgow e Michael Caine. Ele conta a história de uma equipe de astronautas que viaja através de um buraco de minhoca à procura de um novo lar para a humanidade. ",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/3/3a/Interstellar_Filme.png/250px-Interstellar_Filme.png",
                CategoryId = 2
            },
            new Product
            {
                Id = 9,
                Title = "Donnie Darko",
                Description = "Donnie (Jake Gyllenhaal) é um inteligente jovem de classe média, porém antissocial. Ele tem visões de um coelho monstruoso que o convence a fazer brincadeiras humilhantes com seus colegas. Numa dessas visões, o coelho anuncia o fim do mundo em um mês, e eventos terríveis começam a assombrá-lo.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/thumb/5/58/Donnie_Darko.jpg/220px-Donnie_Darko.jpg",
                CategoryId = 2
            }
        );

        modelBuilder.Entity<ProductVariant>().HasData(
            new ProductVariant
            {
                ProductId = 1,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                ProductTypeId = 3,
                Price = 7.99m
            },
            new ProductVariant
            {
                ProductId = 1,
                ProductTypeId = 4,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 2,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant
            {
                ProductId = 2,
                ProductTypeId = 3,
                Price = 7.99m
            },
            new ProductVariant
            {
                ProductId = 2,
                ProductTypeId = 4,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                ProductTypeId = 2,
                Price = 9.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                ProductTypeId = 3,
                Price = 7.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                ProductTypeId = 4,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 11,
                Price = 15.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 12,
                Price = 12.99m,
                OriginalPrice = 19.99m
            },
            new ProductVariant
            {
                ProductId = 5,
                ProductTypeId = 11,
                Price = 19.99m
            },
            new ProductVariant
            {
                ProductId = 5,
                ProductTypeId = 12,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ProductVariant
            {
                ProductId = 6,
                ProductTypeId = 11,
                Price = 9.99m,
                OriginalPrice = 24.99m,
            },
            new ProductVariant
            {
                ProductId = 6,
                ProductTypeId = 12,
                Price = 14.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 6,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 7,
                Price = 79.99m,
                OriginalPrice = 399m
            },
            new ProductVariant
            {
                ProductId = 8,
                ProductTypeId = 6,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ProductVariant
            {
                ProductId = 8,
                ProductTypeId = 7,
                Price = 79.99m,
                OriginalPrice = 399m
            },
            new ProductVariant
            {
                ProductId = 9,
                ProductTypeId = 6,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ProductVariant
            {
                ProductId = 9,
                ProductTypeId = 7,
                Price = 79.99m,
                OriginalPrice = 399m
            }
        );
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
}