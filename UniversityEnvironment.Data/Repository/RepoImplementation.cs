using UniversityEnvironment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Reflection;
using UniversityEnvironment.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace UniversityEnvironment.Data.Repository
{
    public class RepoImplementation<TEntity> : IRepository<TEntity> where TEntity : EnvironmentObject
    {
        private UniversityEnvironmentContext _context;
        private static RepoImplementation<TEntity>? _instance;
        private DbSet<TEntity> _objects;

        private RepoImplementation(UniversityEnvironmentContext context)
        {
            _context = context;
            _objects = context.Set<TEntity>();
        }

        public static RepoImplementation<TEntity> GetRepo(UniversityEnvironmentContext context)
        {
            return _instance ?? new RepoImplementation<TEntity>(context);
        }

        public TEntity Create(TEntity obj)
        {
            _objects.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _objects;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return [.. query]; // ToList()
        }

        public TEntity? GetById(Guid id)
        {
            return _objects.Find(id);
        }

        public TEntity? Update(TEntity obj)
        {
            _objects.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        public TEntity? Delete(TEntity obj)
        {
            if (_context.Entry(obj).State == EntityState.Detached)
            {
                _objects.Attach(obj);
            }

            _objects.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        public TEntity? GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return _objects.FirstOrDefault(filter);
        }
    }
}
