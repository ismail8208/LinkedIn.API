using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IFollowRepository
    {
        public Task<List<User>> GetFollowers(int userId); //Retrieves all followers of a user.
        public Task<List<User>> GetFollowings(int userId); //Retrieves all users that a specific user is following.
        public Task Follow(int userId, int followedUserId); //Allows a user to follow another user.
        public Task Unfollow(int userId, int followedUserId); //Allows a user to unfollow another user.

    }
}
