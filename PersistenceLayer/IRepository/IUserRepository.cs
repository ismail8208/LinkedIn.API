using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IUserRepository
    {
        public Task<List<User>> GetUsers(string name); //search for users based on a name parameter
        public Task<User> GetUserById(int userId); //Retrieves a specific user by their ID
        public Task AddUser(User user); //Creates a new userpu
        public Task UpdateUser(int userId); //Updates an existing user by their ID
        public Task DeleteUser(int userId); //Deletes a user by their ID

        /*
        public Task<List<Experience>> GetUserExperiences(int userId); //Retrieves all experiences for a specific user
        public Task<List<Project>> GetUserProjects(int userId); //Retrieves all projects for a specific user
        public Task<List<Post>> GetUserPosts(int userId); //Retrieves all posts for a specific user
        public Task<List<Education>> GetUserEducations(int userId); //Retrieves all educations for a specific user
        public Task<List<User>> GetUserFollowings(int userId); //Retrieves all followings for a specific user
        public Task<List<User>> GetUserFollowers(int userId); //Retrieves all followers for a specific user
        */
    }
}
