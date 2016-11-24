using MathBlog.Data;
using MathBlog.Models;
using MathBlog.VeiwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathBlog.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {

            ICollection<HomeViewModel> posts =
                this.Context.Posts.Select(p => new HomeViewModel() {
                    Name = p.Name,
                    Content = p.Content,
                    UserName = p.User.UserName,
                    Id = p.Id,
                    Comments = p.Comments,
                    DateCreated = p.DateCreated }).OrderByDescending(p=>p.DateCreated).ToList();
  
            return View(posts);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PostDetails(int Id)
        {
            Post post = this.Context.Posts.FirstOrDefault(p => p.Id == Id);
            HomeViewModel viewPost = new HomeViewModel();
            viewPost.Name = post.Name;
            viewPost.Content = post.Content;
            viewPost.DateCreated = post.DateCreated;
            viewPost.UserName = post.User.UserName;
            viewPost.Id = post.Id;
            viewPost.Comments = post.Comments;
            return View(viewPost);
        }

        [HttpPost]
        public ActionResult Create(HomeViewModel homeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }

            var user = this.Context.Users.FirstOrDefault(u => u.UserName == HttpContext.User.Identity.Name);

            Post post = new Post();
            post.Name = homeViewModel.Name;
            post.Content = homeViewModel.Content;
            post.DateCreated = DateTime.Now;
            post.User = user;

            this.Context.Posts.Add(post);
            this.Context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}