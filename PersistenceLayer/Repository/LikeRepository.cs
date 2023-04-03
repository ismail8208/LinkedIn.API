using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class LikeRepository : ILikeRepository
    {
        public Task AddLike(int postId, Like Like)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLike(int postId, int likeId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Like>> GetLikes(int postId)
        {
            throw new NotImplementedException();
        }
    }
}
