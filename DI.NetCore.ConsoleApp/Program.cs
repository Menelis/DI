using DI.Common.Entities;
using DI.NetCore.Core.Gateways.Interfaces;
using DI.NetCore.Core.Gateways.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.NetCore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IProductRepository _productRepository = ServiceProvider.GetRequiredService<IProductRepository>();

            //return all items
            Console.WriteLine("Items from Seed ProductRepository");
            Console.WriteLine(@"ID---------------------------------------------------------------------------------Name");
            _productRepository.ListAllOrAny().ToList().ForEach(x => Console.WriteLine($@"{x.Id}----------------------------------------{x.Name}"));

            _productRepository.Add(new Product { Id = new Guid("7292C4C1-A100-4FC1-90BD-1F4D74365A60"), Name = "New item from client side" });

            var itemAdded = _productRepository.Get(where: x => x.Id == new Guid("7292C4C1-A100-4FC1-90BD-1F4D74365A60"));

            Console.WriteLine("End of item from Seed");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            Console.WriteLine(@"ID--------------------------------------------------------------Name");
            Console.WriteLine($"{itemAdded.Id}---------------------------------${itemAdded.Name}");
            Console.ReadLine();
        }
        static ServiceProvider ServiceProvider
            => new ServiceCollection()               
               .AddTransient<IProductRepository>(s => new ProductRepository(new List<Product>()))// Dependecy with constructor - https://cmatskas.com/net-core-dependency-injection-with-constructor-parameters-2/
               .BuildServiceProvider();
       


       
        
    }
}
