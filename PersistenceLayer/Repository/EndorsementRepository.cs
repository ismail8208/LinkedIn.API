using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class EndorsementRepository : IEndorsementRepository
    {
        public Task AddEndorsement(int userId, int skillId, Endorsement endorsement)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEndorsement(int userId, int skillId, int endorsementId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Endorsement>> GetEndorsement(int userId, int skillId, int endorsementId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Endorsement>> GetEndorsements(int userId, int skillId)
        {
            throw new NotImplementedException();
        }
    }
}
