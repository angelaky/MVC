using MathBlog.Models;
using MathBlog.VeiwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathBlog.Controllers
{
    public class CommentController : BaseController
    {

        //ET: C Gomment
        [HttpGet]
        public ActionResult AddComment(int Id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddComment(CommentViewModel commentViewModel, int Id)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddComment");
            }

            var user = this.Context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

            Comment comment = new Comment();
            comment.Content = commentViewModel.Content;
            comment.DateCreated = DateTime.Now;
            comment.User = user;
            comment.Post = this.Context.Posts.FirstOrDefault(p => p.Id == Id);
            Post post = this.Context.Posts.FirstOrDefault(p => p.Id == Id);
            this.Context.Comments.Add(comment);
            post.Comments.Add(comment);
            this.Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}