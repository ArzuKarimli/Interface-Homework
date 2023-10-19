using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    internal interface IAccountService
    {
      
        public List<User> AddNewUsers(string username, string password);
        public bool Login(string username, string password);
    }
}
