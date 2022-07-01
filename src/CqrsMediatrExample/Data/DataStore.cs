﻿using CqrsMediatrExample.Models;

namespace CqrsMediatrExample.Data
{
    public class DataStore
    {
        private static List<Product>? _products;
        public DataStore()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1"},
                new Product { Id = 2, Name = "Product 2"},
                new Product { Id = 3, Name = "Product 3"}
            };
        }

        public async Task AddProduct(Product product)
        {
            _products?.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await Task.FromResult(_products!);
        }
    }
}