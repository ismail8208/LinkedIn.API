using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsers(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(int userId, User user)
        {
            throw new NotImplementedException();
        }
    }
}
