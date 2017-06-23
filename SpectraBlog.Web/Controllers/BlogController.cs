using SpectraBlog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc;

namespace SpectraBlog.Web.Controllers
{
    public class BlogController : Controller
    {

        BlogDataContex _db = new BlogDataContex();

        public ActionResult Index()
        {
            var posts = _db.Posts.ToList();
            return View(posts);
        }

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {

           if (ModelState.IsValid)
            {
                _db.Posts.Add(post);
                _db.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(post);
        } 

        public ActionResult Post(long id)
        {
            var post = _db.Posts.Find(id);
            return View(post);

        }

        [HttpPost]
        public ActionResult Post(long id, Comment newComment)
        {
            if (ModelState.IsValid)
            {
                newComment.Post = _db.Posts.Find(id);
                _db.Comments.Add(newComment);
                _db.SaveChanges();

                return RedirectToAction("Post", new { Id = id });
            }
            return Post(id);
        }
    }
}