using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class ExperienceRepository : IExperienceRepository
    {
        public Task AddExperience(int userId, Experience experience)
        {
            throw new NotImplementedException();
        }

        public Task DeleteExperience(int userId, int experienceId)
        {
            throw new NotImplementedException();
        }

        public Task<Experience> GetExperience(int userId, int experienceId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Experience>> GetExperiences(int userId)
        {
            throw new NotImplementedException();
        }

        public Task LinkExperienceWithProject(int userId, int experienceId, int projectId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateExperience(int userId, int experienceId, Experience experience)
        {
            throw new NotImplementedException();
        }
    }
}
