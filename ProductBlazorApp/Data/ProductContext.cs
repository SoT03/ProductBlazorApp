
using Microsoft.EntityFrameworkCore;
using ProductBlazorApp.Models;


namespace ProductBlazorApp.Data;
public class ProductContext(DbContextOptions<ProductContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}



