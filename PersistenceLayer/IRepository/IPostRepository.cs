using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IPostRepository
    {
        public Task<List<Post>> GetPosts(int userId); //Retrieves all posts for a specific user
        public Task<Post> GetPost(int userId, int postId); //Retrieves a specific post of user
        public Task AddPost(int userId,Post post); //Create a new post
        public Task UpdatePost(int userId, int postId, Post post); //Update a specific post by ID
        public Task DeletePost(int userId, int postId); //Delete a specific post by ID


    }
}
