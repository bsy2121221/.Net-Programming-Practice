using ProductsAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ProductsAPI.Repositry
{
  interface IProductsRepositry
    {
        DbSet<Product> GetProducts();
        //IEnumerable<Product> GetAll();
        //Product Get(int id);
        //Product AddProduct(Product item);

        //void Remove(int id);
        //bool Update(Product item);
        
    }
}
