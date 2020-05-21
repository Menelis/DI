using DI.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DI.Common.Specifications
{
    public abstract class BaseSpecification<T> : ISpecification<T>
    {
        protected BaseSpecification(Expression<Func<T, bool>> filter)
        {
            Filter = filter;
        }
        public Expression<Func<T, bool>> Filter { get; }
    }
}
