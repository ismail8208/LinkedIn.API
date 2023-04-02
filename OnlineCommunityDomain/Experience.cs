namespace OnlineCommunityDomain
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public Project Project { get; set; } = new Project();
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ExperienceDate { get; set; }
    }
}
