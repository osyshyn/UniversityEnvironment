using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model;
using UniversityEnvironment.Data.Repository;

namespace UniversityEnvironment.View.Repository
{
    public static class RepositoryManager
    {
        public static IRepository<T> GetRepo<T>(string path) where T : EnvironmentObject
        {
            return RepoImplementation<T>.GetRepo(path);
        }
    }
}
