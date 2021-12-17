using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api1.Controllers
{
    
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
       // [Route("get-all")]
        public string GetAll()
        {
            return "this is get all";
        }
       // [Route("Get-all-author")]
        public string GetAllAuthors()
        {
            return "Get all Authors";
        }
    }
}
