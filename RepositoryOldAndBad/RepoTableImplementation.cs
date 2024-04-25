using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Repository
{
    public class RepoTableImplementation<T> : RepoImplementation<T>, ITableRepository<T> where T : EnvironmentObject
    {
        public delegate void Operation<E, Q, R, W>(List<T> objects, E obj1, Q obj2, R obj3, W obj4);
        public delegate void TableOperation<E>(DataGridView table, List<T> objects, E obj);
        public delegate void TableOperation<E, Q>(DataGridView table, List<T> objects, E obj1, Q obj2);

        private RepoTableImplementation(string DBPath) : base(DBPath)
        {

        }

        public List<T> GetCopyOfObjects()
        {
            return _objects;
        }

        public void ReadAndWriteOperations<E, Q, R, W>(E obj1, Q obj2, R obj3, W obj4, params Operation<E, Q, R, W>[] operations)
        {
            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(_objects, obj1, obj2, obj3, obj4);
                }
            }

            SaveObjects(_objects);
        }

        public void ReadingOperationsWithTable<E>(DataGridView table, int clear, E obj, params TableOperation<E>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }
            var objectsCopy = GetCopyOfObjects();
            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(table, objectsCopy, obj);
                }
            }

        }
        public void ReadAndWriteOperationsWithTable<E>(DataGridView table, int clear, E obj, params TableOperation<E>[] operations)
        {
            switch (clear)
            {
                case 0:
                    break;
                case 1:
                    table.Rows.Clear();
                    break;
                case 2:
                    table.Rows.Clear();
                    table.Columns.Clear();
                    break;
                default:
                    break;
            }

            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(table, _objects, obj);
                }
            }

            SaveObjects(_objects);
        }
    }
}
