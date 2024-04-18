using Newtonsoft.Json;
using UniversityEnvironment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace UniversityEnvironment.Repository
{
    public class RepoImplementation<T> : IRepository<T> where T : EnvironmentObject
    {
        private static RepoImplementation<T>? _instance;
        protected List<T> _objects;

        public string FilePath { get; private set; }
        protected RepoImplementation(string DBpath)
        {
            FilePath = DBpath;
            if (!File.Exists(FilePath))
            {
                using (File.Create(FilePath)) { };
            }
            _objects = GetObjects();
        }

        public static RepoImplementation<T> GetRepo(string DBpath)
        {
            if (_instance == null) _instance = new RepoImplementation<T>(DBpath);
            return _instance;
        }

        private List<T> GetObjects()
        {
            try
            {
                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error reading json: {ex.Message}");
                return new List<T>();
            }
        }

        protected void SaveObjects(List<T> objects)
        {
            try
            {
                string updatedJson = JsonConvert.SerializeObject(objects, Formatting.Indented);
                File.WriteAllText(FilePath, updatedJson);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error reading json: {ex.Message}");
            }

        }
        public void AddObject(T obj)
        {
            _objects.Add(obj);
            SaveObjects(_objects);
        }

        public void ReplaceObjectWith(T obj)
        {
            var existingItemIndex = _objects.FindIndex(i => i.Id == obj.Id);
            if (existingItemIndex != -1)
            {
                _objects[existingItemIndex] = obj;
                SaveObjects(_objects);
            }
        }

        public void DeleteObject(T obj)
        {
            _objects.RemoveAll(i => i.Id == obj.Id);
            SaveObjects(_objects);
        }
        public T GetObjectByFilter(Func<T, bool> filter)
        {
            return _objects.FirstOrDefault(filter);
        }

        public List<T> GetAllObjectsByFilter(Func<T, bool> filter = null)
        {
            return filter != null ? _objects.Where(filter).ToList() : _objects;
        }
    }
}
