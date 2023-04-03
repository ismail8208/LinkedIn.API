namespace OnlineCommunityDomain
{
    public class Endorsement
    {
        public int EndoreId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public int SkillId { get; set; }
        public Skill Skill { get; set; } = new Skill();
    }
}
