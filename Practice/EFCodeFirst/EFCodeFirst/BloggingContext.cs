using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst
{
    public class BloggingContext : DbContext
    {
        public BloggingContext() : base("MyDbConn")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BloggingContext>());
        }        
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
