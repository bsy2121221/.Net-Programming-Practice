using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.DataLayer
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}

