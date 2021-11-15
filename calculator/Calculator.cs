using System;

namespace calculator
{
    public class Calculator
    {
        public int Subtraction(int number1, int number2)
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
    }
}
