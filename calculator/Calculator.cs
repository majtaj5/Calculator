namespace calculator
{
    using System;


    public partial class Calculator
    {

        public double Sum(double number1, double number2)
        {
            return number1 + number2;
        }
        public double Subtraction(double number1, double number2)
        {
            return number1 - number2;
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



