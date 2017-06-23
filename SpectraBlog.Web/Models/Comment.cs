using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpectraBlog.Web.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public Post Post { get; set; }
        public DateTime Created { get; set; }
        public string Autor { get; set; }
        public string Content { get; set; }

        public Comment()
        {

            Created = DateTime.Now;

        }
        
    }
    
}