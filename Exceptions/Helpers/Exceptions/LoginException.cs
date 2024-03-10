using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Helpers.Exceptions
{
    public class LoginException:Exception
    {
        public LoginException(string msj):base(msj)
        {
            
        }

    }
}
