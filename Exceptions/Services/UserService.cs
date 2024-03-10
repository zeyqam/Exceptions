using Exceptions.Helpers.Exceptions;
using Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Services
{
    public class UserService
    {
        private readonly User[] users = new User[]
        {
            new User{Email="test@example.com",Password="password123"}
        };

        public void Login (string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new LoginException("email and password are required");
            }
            User user =Array.Find(users,m=>m.Email == email);

            if (user == null || user.Password!=password)
            {
                throw new LoginException("Invalid email or password.");
            }
            Console.WriteLine("Login successful!");
        }
    }
}
