using MathBlog.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MathBlog.VeiwModels
{
    public class HomeViewModel
    {
        [DisplayName("Post Title")]
        public string Name
        {
            get;
            set;
        }
        [DisplayName("Post Content")]
        public string Content
        {
            get;
            set;
        }

        public string UserName
        {
            get;
            set;
        }

        public DateTime DateCreated
        {
            get;
            set;
        }

        public ICollection<Comment> Comments { get; set; }

        public int Id
        {
            get;
            set;
        }

    }
}