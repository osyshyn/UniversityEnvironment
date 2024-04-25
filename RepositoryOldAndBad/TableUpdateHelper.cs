using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model;

namespace UniversityEnvironment.View.Repository
{
    public static class TableUpdateHelper
    {
        public delegate void Operation<E, Q, R, W>(List<Course> objects, E obj1, Q obj2, R obj3, W obj4);
        public delegate void TableOperation<E>(DataGridView table, List<Course> objects, E obj);

        /*public void ReadAndWriteOperations<E, Q, R, W>(E obj1, Q obj2, R obj3, W obj4, params Operation<E, Q, R, W>[] operations)
        {
            if (operations != null)
            {
                foreach (var operation in operations)
                {
                    operation(_objects, obj1, obj2, obj3, obj4);
                }
            }

            SaveObjects(_objects);
        }*/

        public static void ReadingOperationsWithTable<E>(List<Course> objects,DataGridView table, int clear, E obj, params TableOperation<E>[] operations)
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
                    operation(table, objects, obj);
                }
            }
            // no changes
        }
        public static void ReadAndWriteOperationsWithTable<E>(List<Course> objects,DataGridView table, int clear, E obj, params TableOperation<E>[] operations)
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
                    operation(table, objects, obj);
                }
            }
            // context save object
        }
    }
}
