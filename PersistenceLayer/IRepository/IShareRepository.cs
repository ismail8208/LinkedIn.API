using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IShareRepository
    {
        public Task<List<Share>> GetShares(int postId); //Retrieves all Shares  of a specific post.
        public Task AddShare(int postId, Share Share); //Adds a new Share for a specific post.
        public Task DeleteShare(int postId, int shareId); //Deletes a specific Share of a specific post.
    }
}
