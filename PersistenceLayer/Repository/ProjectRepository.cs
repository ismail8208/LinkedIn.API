using OnlineCommunityDomain;
using PersistenceLayer.IRepository;

namespace PersistenceLayer.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        public Task AddProject(int userId, Project project)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProject(int userId, int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProject(int userId, int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Project>> GetProjects(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProject(int userId, int projectId, Project project)
        {
            throw new NotImplementedException();
        }
    }
}
