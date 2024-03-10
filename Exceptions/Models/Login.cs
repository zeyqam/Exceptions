using Exceptions.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    public  class Login
    {
        public void CheckPassword(string password)
        {
            if (password.Length < 6)
            {
                throw new PasswordLengthException("Password length must be at least 6 characters");
            }
        }
    }
}
