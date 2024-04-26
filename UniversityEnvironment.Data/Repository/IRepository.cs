using UniversityEnvironment.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Linq.Expressions;


namespace UniversityEnvironment.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity? FindById(Guid id);
        TEntity? FindByFilter(Expression<Func<TEntity, bool>> filter);
        TEntity Create(TEntity entity);
        void Create(IEnumerable<TEntity> obj);
        TEntity? Update(TEntity entity);
        TEntity? Delete(TEntity entity);
    }
}
