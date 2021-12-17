using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductsAPI.Repositry;
using ProductsAPI.Models;
using ProductsAPI.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Repositry
{
    public class ProductRepositry : IProductsRepositry
    {
        //private List<Product> products = new List<Product>();
        //private int _nextID = 1;
        //public ProductRepositry()
        //{
        //    AddProduct(new Product { Name = "A", Category = "a", Price = 1 });
        //    AddProduct(new Product { Name = "A", Category = "a", Price = 2 });
        //    AddProduct(new Product { Name = "A", Category = "a", Price = 3 });
        //    AddProduct(new Product { Name = "A", Category = "a", Price = 4 });
        //    AddProduct(new Product { Name = "A", Category = "a", Price = 5 });

        //}
        private readonly ProductContext _context;
        public ProductRepositry(ProductContext context)
        {
            _context = context;
        }
        public DbSet<Product> GetProducts()
        {
            return _context.Products;
        }

        //public IEnumerable<Product> GetAll()
        //{
        //    return products;
        //}
        //public Product Get(int id)
        //{
        //    return products.Find(p => p.Id == id);
        //}

        //public Product AddProduct(Product item)
        //{
        //    if(item==null)
        //    throw new NotImplementedException();
        //    item.Id = _nextID++;
        //    products.Add(item);
        //    return item;
        //}

        //public void Remove(int id)
        //{

        //    products.RemoveAll(p => p.Id == id);
        //}

        //public bool Update(Product item)
        //{
        //    if(item==null)
        //    throw new NotImplementedException();
        //    int index = products.FindIndex(p => p.Id == item.Id);
        //    if (index == -1)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
    }
}
