using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MarkdownSharp;

namespace SpectraBlog.Web.Models
{
    public class Post
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }
        [ScaffoldColumn(false)]
        public DateTime Created { get; set; }


        public string Title { get; set; }
        public string Summary { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public Post()
        {
            Created = DateTime.Now;

        }
    }

    
}