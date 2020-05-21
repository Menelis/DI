using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DI.Common.Interfaces
{
    public  interface IRepository<T>
    {
        void Add(T entity);
        IList<T> ListAllOrAny(Expression<Func<T, bool>> where = null);
        T Get(Expression<Func<T, bool>> where);
    }
}
