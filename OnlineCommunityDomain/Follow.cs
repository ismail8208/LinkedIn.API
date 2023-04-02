namespace OnlineCommunityDomain
{
    public class Follow
    {
        public int FollowID { get; set; }
        public int FollowerID { get; set; }
        public int FolloweeID { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public User Follower { get; set; } = new User();
        public User Followee { get; set; } = new User();
    }
}
