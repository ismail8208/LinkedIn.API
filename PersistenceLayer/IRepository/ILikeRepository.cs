using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface ILikeRepository
    {
        public Task<List<Like>> GetLikes(int postId); //Retrieves all Likes  of a specific post.
        public Task AddLike(int postId, Like Like); //Adds a new Like for a specific post.
        public Task DeleteLike(int postId, int likeId); //Deletes a specific Like of a specific post.
    }
}
