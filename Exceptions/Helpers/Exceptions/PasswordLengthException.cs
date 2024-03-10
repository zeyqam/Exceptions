using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Helpers.Exceptions
{
    public class PasswordLengthException:Exception
    {
        public PasswordLengthException(string msj):base(msj)
        {
            
        }
    }
}
