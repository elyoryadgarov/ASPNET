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
        // public Product GetProductPrice(double Price);
        //
        // public Product GetProductCategoryID(int CategoryID);
        //
        // public Product GetProductOnSale(int OnSale);
        //
        // public Product GetProductStockLevel(int StockLevel);
        

    }
}

