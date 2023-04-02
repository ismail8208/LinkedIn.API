namespace OnlineCommunityDomain
{
    public class Education
    {
        public int EducationId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Level { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
    }
}
