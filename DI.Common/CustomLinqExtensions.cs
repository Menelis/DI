using DI.Common.Entities;
using System;
using System.Collections.Generic;

namespace DI.Common
{
    public static  class CustomLinqExtensions
    {
        public static List<Product> Products => new List<Product>
        {
            new Product { Id = new Guid("C3B0CCEF-2AAD-466C-9F79-EABC00D4EE09"), Name = "First Product" },
            new Product { Id = new Guid("80A5C789-0B3D-4272-BB3E-5356CA792514"), Name = "Second Product" },
            new Product { Id = new Guid("548D97EC-A0D9-43D1-8751-5ECBFD4A70C5"), Name = "Third Product" },
            new Product { Id = new Guid("0C52F5EF-BAD3-4101-9F48-F975F4AF3ABF"), Name = "Fourth Product"},
            new Product { Id = new Guid("C4AEE61D-6742-4973-973B-6D9AB8220C5C"), Name = "Fifth Product" }
         };
    }
}
