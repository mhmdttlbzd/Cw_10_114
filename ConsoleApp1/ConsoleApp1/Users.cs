using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class UsersList
    {
        private static List<User> _users = new List<User>()
        {
            new User(){Id = 1,Name="mohammad",Password="12345",Money=10000000},
        };
        public static List<User> GetAllUsers()
        {

            return _users;
        }
        public static void AddUser(User user)
        {
            var finalUser =new User()
            {
                Name = user.Name,
                Password = user.Password,
                Id = _users.Last().Id+1,
            };
            _users.Add(finalUser);
        }
        public static void RemoveUser(int id) 
        { 
            var user = _users.FirstOrDefault(x => x.Id == id);
            if (user != null) 
            { 
                _users.Remove(user);
            }
        }
        public static User? GetByName(string name)
        {
            return _users.FirstOrDefault(x => x.Name == name);
        }
    }

}
