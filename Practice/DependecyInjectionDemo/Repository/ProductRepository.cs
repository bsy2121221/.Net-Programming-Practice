using DependecyInjectionDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionDemo.Repository
{
    public class ProductRepository : IProductRepository
    {
        List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.ID = products.Count + 1;
            products.Add(product);
            return product.ID;

        }

        public string GetName()
        {
            return "Name from ProductRepositry";
        }

        public List<ProductModel> GetProducts()
        {
            return products;
        }
    }
}
