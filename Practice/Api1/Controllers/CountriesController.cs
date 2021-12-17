using Api1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

   // [BindProperties(SupportsGet =true)]
    public class CountriesController : ControllerBase
    {
        //[BindProperty]
        //public string Name { get; set; }
        //[BindProperty]
        //public int Population { get; set; }
        //[BindProperty]
        //public int Area { get; set; }

       // [BindProperty]
        //public CountryModel Country { get; set; }

        //[HttpPost("")]
        //[HttpPost("")]
        //public IActionResult AddCountry([FromQuery]CountryModel country)
        //{
        //    //return Ok($"Name:{ this.Country.Name},Population:{this.Country.Population},Area:{this.Country.Area}");
        //    return Ok($"Name:{country.Name}");
        //}

        //using custom model binder
        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(ModelBinder.CustomModelBinder))]string[] countries)
        {

            return Ok(countries);
        }

        [HttpGet("{id}")]
        public IActionResult CountryDetails(CountryModel country)
        {
            return Ok(country);
        }
    }
}
