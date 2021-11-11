using Microsoft.EntityFrameworkCore;

namespace DotNet.API.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<List> Lists { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<List>().ToTable("List");
            modelBuilder.Entity<Item>().ToTable("Item");

            modelBuilder.Entity<List>()
                .HasMany(l => l.Items)
                .WithOne(i => i.List)
                .IsRequired();

            modelBuilder.Entity<List>().HasData(
                new List { ListId = 1, Name = "Home" },
                new List { ListId = 2, Name = "School" });

            modelBuilder.Entity<Item>().HasData(
                new Item { ItemId = 1, ListId = 1, Description = "Cooking" },
                new Item { ItemId = 2, ListId = 1, Description = "Cleaning" });
        }

    }
}
