using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public long Price { get; set; }
    }
    public class PC : Product 
    {
        public string Brand { get; set; }
        public List<InnerProduct> InnerProducts{ get; set;}
    }

    public class InnerProduct :Product
    {

    }
    public class CPU : InnerProduct
    {
        public string Brand { get; set; }
        public int Core { get; set; }
    }
    public class Ram : InnerProduct
    {
        public long MemoryByte { get; set; }
    }
}
