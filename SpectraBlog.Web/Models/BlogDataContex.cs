using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpectraBlog.Web.Models
{
    public class BlogDataContex : DbContext
    {
        public  DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

    
}