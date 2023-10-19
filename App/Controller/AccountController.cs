using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Controller
{
    internal class AccountController
    {
        public readonly AccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void AuthenticateOfAccount()
        {
            AccountService accountService = _accountService;
            _accountService.AddNewUsers("arzu", "arzu123");
            Console.WriteLine("Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            if (_accountService.Login(username, password))
            {
                Console.WriteLine("Login success");
            }
            else
            {
                Console.WriteLine("Wrong username or password. Please try again.");
            }

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and Password can't be Empty");
            }
        }
    }
}
