namespace OnlineCommunityDomain
{
    public class Like
    {
        public int LikeID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public User User { get; set; } = new User();
        public Post Post { get; set; } = new Post();
    }
}
