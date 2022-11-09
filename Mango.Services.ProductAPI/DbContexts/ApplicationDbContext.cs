using Mango.Services.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samose",
                Price = 15,
                Description = "This is description",
                ImageUrl = "https://picsum.photos/200",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Pika",
                Price = 10,
                Description = "This is description",
                ImageUrl = "https://picsum.photos/id/237/200/300",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Amazon",
                Price = 20,
                Description = "This is description",
                ImageUrl = "https://picsum.photos/200/300",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Ahit",
                Price = 30,
                Description = "This is description",
                ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                CategoryName = "Appetizer"
            });

        }
    }
}
