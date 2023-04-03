namespace OnlineCommunityDomain
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;

        // Navigation properties
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Experience> Experiences { get; set; } = new List<Experience>();
        public List<Endorsement> Endores { get; set; } = new List<Endorsement>();
        public List<Education> Educations { get; set; } = new List<Education>();
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Follow> Followers { get; set; } = new List<Follow>();
        public List<Follow> Followees { get; set; } = new List<Follow>();
        public List<Share> SharedPosts { get; set; } = new List<Share>();
        public List<Like> Likes { get; set; } = new List<Like>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
