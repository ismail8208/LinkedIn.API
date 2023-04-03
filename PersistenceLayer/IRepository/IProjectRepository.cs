using OnlineCommunityDomain;

namespace PersistenceLayer.IRepository
{
    public interface IProjectRepository
    {
        public Task<List<Project>> GetProjects(int userId); //Retrieves all Projects of a user.
        public Task<Project> GetProject(int userId, int projectId); //Retrieves a specific Project of a user.
        public Task AddProject(int userId, Project project); //Adds a new Project for a user.
        public Task UpdateProject(int userId, int projectId); //Updates a specific Project  of a user.
        public Task DeleteProject(int userId, int projectId); //Deletes a specific Project of a user.

    }
}
