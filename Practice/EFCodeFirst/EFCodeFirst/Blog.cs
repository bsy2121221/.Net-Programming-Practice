using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
