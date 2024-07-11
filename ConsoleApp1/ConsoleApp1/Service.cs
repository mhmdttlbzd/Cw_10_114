using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service
    {
        public bool Login(string username, string password)
        {
            var user = UsersList.GetByName(username);
            if (user != null)
            {
                if (user.Password == password) return true;
            }
            return false;
        }
        public bool Register(string username, string password)
        {
            var correntUser = UsersList.GetByName(username);
            if (correntUser != null) return false;
            var user = new User() { Name = username, Password = password };
            UsersList.AddUser(user);
            return true;
        }
        public List<Product> GetAllProducts()
        {
            return Store.Products;
        }
        public bool AddMoney(string username, long money)
        {
            var user = UsersList.GetByName(username);
            if (user != null)
            {
                user.Money += money;
                return true;
            }
            return false;
        }
        public bool Buy(int productId,string username)
        {
            var user = UsersList.GetByName(username);
            if (user != null) {
                var product = Store.Products.FirstOrDefault(x => x.Id == productId);
                if (product != null) {
                    long price = product.Price;
                    if (product is PC)
                    {
                       var pc = product as PC;
                        
                        foreach (var item in pc.InnerProducts)
                        {
                            price += item.Price;
                        }
                    }

                    if (user.Money >= price)
                    {
                        user.Products.Add(product);
                        user.Money -= price;
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Product> GetAllListProduct(string name)
        {
            var user = UsersList.GetByName(name);
            return user.Products;
           
        }

    }
}
