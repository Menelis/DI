using DI.Common;
using DI.Common.Entities;
using DI.Common.Interfaces;
using DI.NetCore.Core.Gateways.Interfaces;
using System.Collections.Generic;

namespace DI.NetCore.Core.Gateways.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IList<Product> items) : base(items)
        {
           CustomLinqExtensions.Products.ForEach(x => items.Add(x));
        }
    }
}
