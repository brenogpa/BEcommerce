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
            },
            new Product
            {
                Id = 10,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                CategoryId = 1,
            },
            new Product
            {
                Id = 11,
                Title = "Ready Player One",
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 12,
                Title = "Nineteen Eighty-Four",
                Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 13,
                CategoryId = 2,
                Title = "The Matrix",
                Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
            },
            new Product
            {
                Id = 14,
                CategoryId = 2,
                Title = "Back to the Future",
                Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
            },
            new Product
            {
                Id = 15,
                CategoryId = 2,
                Title = "Toy Story",
                Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
            },
            new Product
            {
                Id = 16,
                CategoryId = 3,
                Title = "Half-Life 2",
                Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
            },
            new Product
            {
                Id = 17,
                CategoryId = 3,
                Title = "Diablo II",
                Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
            },
            new Product
            {
                Id = 18,
                CategoryId = 3,
                Title = "Day of the Tentacle",
                Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
            },
            new Product
            {
                Id = 19,
                CategoryId = 4,
                Title = "Xbox",
                Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
            },
            new Product
            {
                Id = 20,
                CategoryId = 4,
                Title = "Super Nintendo Entertainment System",
                Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
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
                Price = 7.99m,
                OriginalPrice = 14.99m
            },
            new ProductVariant
            {
                ProductId = 3,
                ProductTypeId = 2,
                Price = 6.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 5,
                Price = 3.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 6,
                Price = 9.99m
            },
            new ProductVariant
            {
                ProductId = 4,
                ProductTypeId = 7,
                Price = 19.99m
            },
            new ProductVariant
            {
                ProductId = 5,
                ProductTypeId = 5,
                Price = 3.99m,
            },
            new ProductVariant
            {
                ProductId = 6,
                ProductTypeId = 5,
                Price = 2.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 8,
                Price = 19.99m,
                OriginalPrice = 29.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 9,
                Price = 69.99m
            },
            new ProductVariant
            {
                ProductId = 7,
                ProductTypeId = 10,
                Price = 49.99m,
                OriginalPrice = 59.99m
            },
            new ProductVariant
            {
                ProductId = 8,
                ProductTypeId = 8,
                Price = 9.99m,
                OriginalPrice = 24.99m,
            },
            new ProductVariant
            {
                ProductId = 9,
                ProductTypeId = 8,
                Price = 14.99m
            },
            new ProductVariant
            {
                ProductId = 10,
                ProductTypeId = 1,
                Price = 159.99m,
                OriginalPrice = 299m
            },
            new ProductVariant
            {
                ProductId = 11,
                ProductTypeId = 1,
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