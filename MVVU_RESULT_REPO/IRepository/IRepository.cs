using MVVU_RESULT_DATA;
using MVVU_RESULT_DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MVVU_RESULT_REPO
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(object Id);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(object Id);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
