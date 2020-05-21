using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DI.Common.Interfaces
{
    public  interface IRepository<T>
    {
        void Add(T entity);
        IList<T> ListAllOrAny(ISpecification<T> filter = null);
        T Get(ISpecification<T> filter);
    }
}
