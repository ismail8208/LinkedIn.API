using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IExperienceRepository
    {
        public Task<List<Experience>> GetExperiences(int userId); //Retrieves all Experience of a user.
        public Task<Experience> GetExperience(int userId, int experienceId); //Retrieves a specific Experience of a user.
        public Task AddExperience(int userId, Experience experience); //Adds a new Experience for a user.
        public Task UpdateExperience(int userId, int experienceId); //Updates a specific Experience  of a user.
        public Task DeleteExperience(int userId, int experienceId); //Deletes a specific Experience of a user.
        public Task LinkExperienceWithProject(int userId, int experienceId, int projectId); //Link existing Experince with existing Project 
    }
}
