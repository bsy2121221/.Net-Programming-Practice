using DependecyInjectionDemo.Model;
using DependecyInjectionDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependecyInjectionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductRepository _productRepository;
        public readonly IProductRepository _productRepository1;
        public ProductController(IProductRepository productrepositry, IProductRepository productrepositry1)
        {
            _productRepository = productrepositry;
            _productRepository1 = productrepositry1;
        }
        [HttpPost("")]
        public IActionResult AddProducts([FromBody]ProductModel product)
        {
            _productRepository.AddProduct(product);
            //we are setting data with one instance and getting data with another instance
            //because we are using singelton method to register the service so only one instance is created and 
            //it will share with all.
            var products = _productRepository1.GetProducts();
            return Ok(products);
        }
        [HttpGet("")]
        public IActionResult GetName()
        {

            return Ok(_productRepository.GetName());
        }
    }
}
