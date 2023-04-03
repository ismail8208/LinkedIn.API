using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IEndorsementRepository
    {
        public Task<List<Endorsement>> GetEndorsements(int userId, int skillId); //Retrieves all endorsements for a specific skill of a user.
        public Task<List<Endorsement>> GetEndorsement(int userId, int skillId, int endorsementId); //Retrieves a specific endorsement of skill.
        public Task AddEndorsement(int userId, int skillId, Endorsement endorsement); //Adds a new endorsement for a specific skill of a user.
        public Task DeleteEndorsement(int userId, int skillId, int endorsementId); //Deletes a specific endorsement for a specific skill of a user.
    }
}
