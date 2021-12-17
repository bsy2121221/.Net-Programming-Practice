using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api1.Model;

namespace Api1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexerController : ControllerBase
    {
        EmployeeIndexer emp = new EmployeeIndexer(1001, 12000, "bsy", "Sf Engineer", "IT", "Noida");
       public string Get()
        {
            return "Eno= "+emp[0]+"\nSalary= "+emp[1]+"\nEname= "+emp[2]+"\nJob= "+emp[3]+"\nDname= "+emp[4]+"\nLocation= "+emp[5];
        }
    }
}
