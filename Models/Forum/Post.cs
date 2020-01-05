using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumProject.Models.Forum
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public int Likes { get; set; }
        public bool IsDeleted { get; set; }
        public string User { get; set; }
        public string URL { get; set; }
    }
}
