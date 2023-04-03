using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class EducationRepository : IEducationRepository
    {
        public Task AddEducation(int userId, Education education)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEducation(int userId, int educationId)
        {
            throw new NotImplementedException();
        }

        public Task<Education> GetEducation(int userId, int educationId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Education>> GetEducations(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEducation(int userId, int educationId, Education education)
        {
            throw new NotImplementedException();
        }
    }
}
