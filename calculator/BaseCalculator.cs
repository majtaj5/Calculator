using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class BaseCalculator
    {
        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        public int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
        public double Division(double number1, double number2)
        {
            return Math.Round(number1 / number2, 2);
        }
        public double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

    }
}
