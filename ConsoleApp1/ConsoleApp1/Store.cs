using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Store
    {
        public static List<Product> Products { get;private set; } = new List<Product>();
        public static void SetDefaultProducts()
        {
            Products.Add(new PC { Id = 0,Name="PC1",Description="new pc for you",Brand="Asus",Price= 20000000});
            Products.Add(new CPU { Id = 1, Name = "CPU1", Description = "new cpu", Brand = "intel", Price = 5000000, Core = 5 });
            Products.Add(new CPU { Id = 2, Name = "CPU2", Description = "new cpu", Brand = "intel", Price = 5000000, Core = 5 });
            Products.Add(new Ram { Id = 3, Name = "Ram1", Description = "new ram", MemoryByte = 8000, Price = 800000 });
            var pc = Products.First(x => x is PC)as PC;
            pc.InnerProducts.Add(Products.First(x => x is CPU&& x.Id==2)as InnerProduct);
            pc.InnerProducts.Add(Products.First(y => y is Ram)as InnerProduct);
        }
    }
}
