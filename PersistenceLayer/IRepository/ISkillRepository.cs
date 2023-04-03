using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface ISkillRepository
    {
        public Task<List<Skill>> GetSkills(string name); //search for Skills based on a name parameter
        public Task<List<Skill>> GetSkills(int userId); //Retrieves all skills for a specific user
        public Task<Skill> GetSkill(int userId, int skillId); //Retrieve a specific skill by user id and skill id
        public Task AddSkill(int userId, Skill skill); //create a new skill
        public Task DeleteSkill(int userId,int skillId); //delete an existing skill by user id and skill id
    }
}
