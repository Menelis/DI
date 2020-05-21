using DI.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DI.Common.Specifications
{
    public class ProductSpecification : BaseSpecification<Product>
    {
        public ProductSpecification(Expression<Func<Product, bool>> filter) : base(filter) { }
    }
}
