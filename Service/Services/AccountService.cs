using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public readonly List<User> users;
        public AccountService()
        {
            users = new List<User>();
        }

    

        public List<User> AddNewUsers(string username, string password)
        {
            User newUser = new User { Username = username, Password = password };
            users.Add(newUser);
            return users;

        }

        public bool Login(string username, string password)
        {
            User CheckAccount = users.FirstOrDefault(m => m.Username == username && m.Password == password);
            return CheckAccount != null;
        }
    }
}
