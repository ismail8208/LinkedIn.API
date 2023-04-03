using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IEducationRepository
    {
        public Task<List<Education>> GetEducations(int userId); //Retrieves all education experiences of a user.
        public Task<Education> GetEducation(int userId, int educationId); //Retrieves a specific education experience of a user.
        public Task AddEducation(int userId, Education education); //Adds a new education experience for a user.
        public Task UpdateEducation(int userId, int educationId); //Updates a specific education experience of a user.
        public Task DeleteEducation(int userId, int educationId); //Deletes a specific education experience of a user.

    }
}
