using System;
using System.Linq.Expressions;

namespace DI.Common.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Filter { get; }
    }
}
