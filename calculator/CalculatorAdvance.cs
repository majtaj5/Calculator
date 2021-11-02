using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class CalculatorAdvance : IAdvanceMaths
    {
        public int fac(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int mean(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int pernum(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public int pow(int num1, int num2)
        {
            {
                int result = 1;

                for (int i = 0; i < num2; i++)
                {

                    result = result * num1;

                }
                return result;



            }
        }
    }
}
