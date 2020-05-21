using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using DI.Common.Entities;
using DI.Common.Specifications;
using DI.Framework.Core.Gateways.Interfaces;
using DI.Framework.Core.Gateways.Repositories;

namespace DI.Framework.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductRepository _productRepository = Container.Resolve<IProductRepository>();

            //return all items
            Console.WriteLine("Items from Seed ProductRepository");
            Console.WriteLine(@"ID---------------------------------------------------------------------------------Name");
            _productRepository.ListAllOrAny().ToList().ForEach(x => Console.WriteLine($@"{x.Id}----------------------------------------{x.Name}"));

            _productRepository.Add(new Product { Id = new Guid("7292C4C1-A100-4FC1-90BD-1F4D74365A60"), Name = "New item from client side" });

            var itemAdded = _productRepository.Get(new ProductSpecification(p => p.Id == new Guid("7292C4C1-A100-4FC1-90BD-1F4D74365A60")));

            Console.WriteLine("End of item from Seed");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"ID--------------------------------------------------------------Name");
            Console.WriteLine($"{itemAdded.Id}---------------------------------${itemAdded.Name}");
            Console.ReadLine();
        }
        static IContainer Container
        {
            get
            {
                var container = new ContainerBuilder();
                container.RegisterType<ProductRepository>().As<IProductRepository>();
                return container.Build();
            }
        }
    }
}
