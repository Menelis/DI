using DI.Common.Entities;
using DI.Common.Interfaces;


namespace DI.Framework.Core.Gateways.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        //Other methods other than generic CRUD from IReposiory
    }
}
