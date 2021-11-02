using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class CalculatorBasic : IBasicMaths
    {
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1+ num2;
        }
    }
}
