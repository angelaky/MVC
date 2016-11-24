using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBlog.Models
{
    public class Comment
    {
        public int Id
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public DateTime DateCreated
        {
            get;
            set;
        }

        public virtual ApplicationUser User
        {
            get;
            set;
        }

        public virtual Post Post
        {
            get;
            set;
        }
    }
}
