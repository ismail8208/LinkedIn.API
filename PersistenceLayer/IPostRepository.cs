using OnlineCommunityDomain;

namespace PersistenceLayer
{
    public interface IPostRepository
    {
        public Task<List<Post>> GetPostsAsync(int userId); //latest News
        public Task<Post> GetPostAsync(int userId, int postId);
        public Task<List<Comment>> GetCommentsAsync(int userId, int postId);



    }
}
