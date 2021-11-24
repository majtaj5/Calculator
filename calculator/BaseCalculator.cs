using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class BaseCalculator
    {
        protected static double Subtraction(double number1, double number2) => number1 - number2;
        protected static double Addition(double number1, double number2) => number1 + number2;
        protected static double Division(double number1, double number2) => Math.Round(number1 / number2, 2);
        protected static double Multiplication(double number1, double number2) => number1 * number2;

    }
}
