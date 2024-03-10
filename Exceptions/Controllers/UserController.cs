using Exceptions.Helpers.Exceptions;
using Exceptions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Controllers
{
    public  class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public void Handlelogin(string email, string password)
        {
            try
            {
                _userService.Login(email, password);
            }
            catch (LoginException ex)
            {

                Console.WriteLine($"Login failed: { ex.Message}");
            }

        }
    }
}
