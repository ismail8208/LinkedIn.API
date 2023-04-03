using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class SkillRepository : ISkillRepository
    {
        public Task AddSkill(int userId, Skill skill)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSkill(int userId, int skillId)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> GetSkill(int userId, int skillId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetSkills(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Skill>> GetSkills(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
