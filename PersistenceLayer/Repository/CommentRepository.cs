using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public Task AddComment(int postId, Comment Comment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComment(int postId, int CommentId)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetComment(int postId, int CommentId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetComments(int postId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateComment(int postId, int CommentId, Comment Comment)
        {
            throw new NotImplementedException();
        }
    }
}
