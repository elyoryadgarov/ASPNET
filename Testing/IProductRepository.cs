using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);
        public Product GetProductName(string Name);
        void UpdateProduct(Product product);
        public void InsertProduct(Product ProductToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void  DeleteProduct(Product product);
    }
}

