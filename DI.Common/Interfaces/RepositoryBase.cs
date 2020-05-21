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
        public  IList<T> ListAllOrAny(ISpecification<T> criteria = null)
        {
            return criteria == null ? _items : _items.AsQueryable().Where(criteria.Filter).ToList();
        }

        public T Get(ISpecification<T> criteria)
        {
            return ListAllOrAny(criteria).FirstOrDefault();
        }
    }
}
