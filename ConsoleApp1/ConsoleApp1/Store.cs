using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Store
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static void SetDefaultProducts()
        {
            Products.Add(new PC { Id = 0,Name="PC1",Description="new pc for you",Brand="Asus",Price= });
        }
    }
}
