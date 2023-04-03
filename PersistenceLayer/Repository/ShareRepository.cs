using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class ShareRepository : IShareRepository
    {
        public Task AddShare(int postId, Share Share)
        {
            throw new NotImplementedException();
        }

        public Task DeleteShare(int postId, int shareId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Share>> GetShares(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
