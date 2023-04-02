namespace OnlineCommunityDomain
{
    public class Project
    {
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public int? ExperienceId { get; set; }
        public Experience Experience { get; set; } = new Experience();
        public string Content { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
