namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "The Lies of Locke Lamora",
                        Description = "The Lies of Locke Lamora is a 2006 fantasy novel by American writer Scott Lynch, the first book of the Gentleman Bastard series. Elite con artists calling themselves the \"Gentleman Bastards\" rob the rich of the city of Camorr, based on late medieval Venice but on an unnamed world.[2] Two stories interweave: in the present, the Gentleman Bastards fight a mysterious Grey King taking over the criminal underworld; alternate chapters describe the history of Camorr and the Gentleman Bastards, in particular Locke Lamora.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b1/Locke_Lamora.jpg",
                        Price = 9.99m
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Gardens of the Moon",
                        Description = "Gardens of the Moon is the first novel in the Malazan Book of the Fallen epic fantasy series. It was written by Steven Erikson in 1991 and extensively revised over several years before first being published by Bantam Books[1] on April 1, 1999 in Great Britain and Canada. In 2000, it was nominated for a World Fantasy Award as one of the year's best fantasy novels.[2] On December 28, 2004, Tor Books released it in the United States, and it has since been re-released in multiple editions and in many countries.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/76/Three_Gardens_of_the_Moon.jpg",
                        Price = 9.99m
                    }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
