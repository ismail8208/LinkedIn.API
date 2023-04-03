using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class PostRepository : IPostRepository
    {
        public Task AddPost(int userId, Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPost(int userId, int postId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPosts(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePost(int userId, int postId, Post post)
        {
            throw new NotImplementedException();
        }
    }
}
