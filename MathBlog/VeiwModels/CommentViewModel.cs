using MathBlog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MathBlog.VeiwModels
{
    public class CommentViewModel
    {
        
        [DisplayName("Add Comment")]
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

        public int PostId
        {
            get;
            set;
        }
    }
}