﻿
namespace calculator
{
    class CalculatorOperations
    {
        public static double Count(double number1db, double number2db, char operations)
        {
            double result = 0;

            switch (operations)
            {
                case '+':
                    result = number1db + number2db;
                    break;
                case '-':
                    result = number1db - number2db;
                    break;
                case '*':
                    result = number1db * number2db;
                    break;
                case '/':
                case '\\':
                    result = number1db / number2db;
                    break;
            }
            return result;
        }
    }
}
