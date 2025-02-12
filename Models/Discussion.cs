using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GalaxyForum.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; }  // Primary key
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ImageFilename { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<Comment>? Comments
        {
            get; set;
        }
    }
}

