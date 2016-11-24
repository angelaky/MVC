using MathBlog.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlog.Data
{
    public class MathBlogDbContext : IdentityDbContext<ApplicationUser>
    {
        public MathBlogDbContext()
        : base("MathSystemITStep")
        {
        }

        public static MathBlogDbContext Create()
        {
            return new MathBlogDbContext();
        }
        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Comment> Comments { get; set; }

    }
}
