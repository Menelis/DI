using DI.Common.Entities;
using DI.Common.Interfaces;

namespace DI.NetCore.Core.Gateways.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
