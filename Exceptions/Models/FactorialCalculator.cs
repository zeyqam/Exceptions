using Exceptions.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    public  class FactorialCalculator
    {
        public static int CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new NegativNumberException("Menfi eded daxil etmisiz.Factorial hesablamaq olmaz");
            }
            if (number == 0 || number == 1)
            {
                return 1;
            }
            int factorial = 1;
            for(int i = 0; i < number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
