using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IEducationRepository
    {
        public Task<List<Education>> GetEducations(int userId); //Retrieves all education of a user.
        public Task<Education> GetEducation(int userId, int educationId); //Retrieves a specific education of a user.
        public Task AddEducation(int userId, Education education); //Adds a new education for a user.
        public Task UpdateEducation(int userId, int educationId, Education education); //Updates a specific education of a user.
        public Task DeleteEducation(int userId, int educationId); //Deletes a specific education of a user.

    }
}
