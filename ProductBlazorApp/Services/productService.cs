﻿using Microsoft.EntityFrameworkCore;
using ProductBlazorApp.Data;
using ProductBlazorApp.Models;

namespace ProductBlazorApp.Services
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

        // Method to get add products
        public async Task AddProductAsync(Product product)
        {

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

        }

        // Method to search product by id

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        //Method to update product

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
             await _context.SaveChangesAsync();
        }

        //Method to delete product

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await GetProductByIdAsync(id);

            if(product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }

        
    }
}
