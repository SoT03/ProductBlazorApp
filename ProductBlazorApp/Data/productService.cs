using Microsoft.EntityFrameworkCore;
using ProductBlazorApp.Models;

namespace ProductBlazorApp.Data
{
    public class ProductService(ProductContext context)
    {
        private readonly ProductContext _context = context;

        
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
