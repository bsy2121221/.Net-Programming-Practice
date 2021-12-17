using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWithEFDemo.Model
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
    }
}
