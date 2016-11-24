using MathBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathBlog.Controllers
{
    public class BaseController : Controller
    {
        //winagi prazen konstruktor
        public BaseController(): this (new MathBlogDbContext())
        {
                
        }

        public BaseController(MathBlogDbContext context)
        {
            this.Context = context;
        }

        protected MathBlogDbContext Context

        {
            get;
            set;
        }
        // GET: Base
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}