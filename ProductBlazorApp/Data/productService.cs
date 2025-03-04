using Microsoft.EntityFrameworkCore;
using ProductBlazorApp.Models;

namespace ProductBlazorApp.Data
{
    public class ProductService
    {
 
        private readonly ProductContext _context;

      
        public ProductService(ProductContext context)
        {
            _context = context;
        }

        // Method to get all products
        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
