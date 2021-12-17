using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProductsAPI.Repositry;
using ProductsAPI.Models;
using ProductsAPI.DataLayer;
using System.Linq;

namespace ProductsAPI.Controllers
{
   [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
      private readonly IProductsRepositry _repositry;
        private ProductContext _context;
        public ProductsController(ProductContext context)
        {
            _repositry = new ProductRepositry(context);
            _context = context;
        }
       

        [HttpGet]
        public IEnumerable<Product> List()
        {
            return _repositry.GetProducts();
        }

        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _context.Products.Add(value);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            var product = _context.Products.FirstOrDefault(s => s.Id == id);
            if (product != null)
            {
                _context.Entry<Product>(product).CurrentValues.SetValues(value);
                _context.SaveChanges();
            }
            else
            {
                NotFound();
            }
             
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = _context.Products.FirstOrDefault(s => s.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            else
            {
                NotFound();
            }
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(s => s.Id == id);
        }


    }
}
