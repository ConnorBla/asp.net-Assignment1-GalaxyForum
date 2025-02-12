namespace GalaxyForum.Models
{
    public class Comment
    {
        public int CommentId { get; set; }  // Primary key
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int DiscussionId { get; set; }

        public Discussion? Discussion { get; set; }
    }
}
