namespace OnlineCommunityDomain
{
    public class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public string VideoURL { get; set; } = string.Empty;
        public int NumberOfLikes { get; set; }
        public int NumberOfComments { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        // Navigation properties
        public User User { get; set; }
        public List<Like> Likes { get; set; } = new List<Like>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Share> Shares { get; set; } = new List<Share>();

    }
}
