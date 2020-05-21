using DI.Common;
using DI.Common.Entities;
using DI.Common.Interfaces;
using DI.Framework.Core.Gateways.Interfaces;
using System.Collections.Generic;

namespace DI.Framework.Core.Gateways.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IList<Product> items) : base(items)
        {
           CustomLinqExtensions.Products.ForEach(x => items.Add(x));
        }
        
        //Add other methods other than CRUD methods here
    }
}
