using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DI.Common.Interfaces
{
    public abstract class RepositoryBase<T> where T : class
    {
        private readonly IList<T> _items;
        protected RepositoryBase(IList<T> items)
        {
            _items = items;
        }

        public void Add(T entity)
        {
            _items.Add(entity);
        }
        public  IList<T> ListAllOrAny(Expression<Func<T, bool>> where = null)
        {
            return where == null ? _items : _items.AsQueryable().Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return ListAllOrAny(where).FirstOrDefault();
        }
    }
}
