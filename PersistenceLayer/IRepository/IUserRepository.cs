using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IUserRepository
    {
        public Task<List<User>> GetUsers(string name); //search for users based on a name parameter
        public Task<User> GetUserById(int userId); //Retrieves a specific user by their ID
        public Task AddUser(User user); //Creates a new userpu
        public Task UpdateUser(int userId, User user); //Updates an existing user by their ID
        public Task DeleteUser(int userId); //Deletes a user by their ID
    }
}
