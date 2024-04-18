using UniversityEnvironment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UniversityEnvironment.Repository
{
    public interface IRepository<T> where T : EnvironmentObject
    {
        List<T> GetAllObjectsByFilter(Func<T, bool> filter = null);
        void AddObject(T Entity);
        void ReplaceObjectWith(T Entity);
        void DeleteObject(T Entity);
        T GetObjectByFilter(Func<T, bool> filter);
    }

    public interface ITableRepository<T> where T : EnvironmentObject
    {
        List<T> GetCopyOfObjects();
        void ReadAndWriteOperations<E, Q, R, W>(E obj1, Q obj2, R obj3, W obj4, params RepoTableImplementation<T>.Operation<E, Q, R, W>[] operations);
        void ReadingOperationsWithTable<E>(DataGridView table, int clear, E obj, params RepoTableImplementation<T>.TableOperation<E>[] operations);
        void ReadAndWriteOperationsWithTable<E>(DataGridView table, int clear, E obj, params RepoTableImplementation<T>.TableOperation<E>[] operations);
    }
}
