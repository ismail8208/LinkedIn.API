using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface ICommentRepository
    {
        public Task<List<Comment>> GetComments(int postId); //Retrieves all Comments  of a specific post.
        public Task<Comment> GetComment(int postId, int CommentId); //Retrieves a specific Comment of a specific post.
        public Task AddComment(int postId, Comment Comment); //Adds a new Comment for a specific post.
        public Task UpdateComment(int postId, int CommentId, Comment Comment); //Updates a specific Comment of a specific post.
        public Task DeleteComment(int postId, int CommentId); //Deletes a specific Comment of a specific post.

    }
}
