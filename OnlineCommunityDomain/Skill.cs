namespace OnlineCommunityDomain
{
    public class Skill
    {
        public int SkillId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public string Title { get; set; } = string.Empty;
        public List<Endorsement> Endorsements { get; set; } = new List<Endorsement>();
    }
}
