using DependecyInjectionDemo.Model;
using System.Collections.Generic;

namespace DependecyInjectionDemo.Repository
{
    public interface IProductRepository
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetProducts();
        string GetName();
    }
}