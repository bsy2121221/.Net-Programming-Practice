using DependecyInjectionDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionDemo.Repository
{
    public class TestRepository : IProductRepository
    {
        public int AddProduct(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return "Name from TestRepository";
        }

        public List<ProductModel> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
