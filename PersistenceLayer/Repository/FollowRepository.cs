using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class FollowRepository : IFollowRepository
    {
        public Task Follow(int userId, int followedUserId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetFollowers(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetFollowings(int userId)
        {
            throw new NotImplementedException();
        }

        public Task Unfollow(int userId, int followedUserId)
        {
            throw new NotImplementedException();
        }
    }
}
