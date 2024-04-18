using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Models;

namespace UniversityEnvironment.Repository
{
    public static class RepositoryManager
    {
        public static IRepository<T> GetRepo<T>(string path) where T : EnvironmentObject
        {
            return RepoImplementation<T>.GetRepo(path);
        }
    }
}
