using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Repository;

namespace UniversityEnvironment.Data.Repositories
{
    public static class RepositoryManager
    {
        public static IRepository<TEntity> GetRepo<TEntity>() where TEntity : EnvironmentObject
        {
            var context = new UniversityEnvironmentContext();
            var repository = RepoImplementation<TEntity>.GetRepo(context);
            return repository;
        }
    }
}