using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace calculator
{
    public class  Calculator
    {
        public static void Calculate()
        {

            string usreInPut = "4   -2";
            string userInPutRemoveWhitespace = usreInPut.Replace(" ", "");

            int posChar = userInPutRemoveWhitespace.IndexOf("-");
            string number1 = " ";
            string number2 = " ";

            for (int i = 0; i < posChar; i++)
            {
                number1 = number1 + userInPutRemoveWhitespace[i];
            }

            for (int j = posChar + 1; j < userInPutRemoveWhitespace.Length; j++)
            {
                number2 = number2 + userInPutRemoveWhitespace[j];
            }
            Console.WriteLine(number1);


            char operations = userInPutRemoveWhitespace[posChar];

            Console.WriteLine(operations);
        }


        //calculation methods
        public static double Subtraction(double number1, double number2) => number1 - number2;
        public static double Addition(double number1, double number2) => number1 + number2;
        public static double Division(double number1, double number2) => Math.Round(number1 / number2, 2);
        public static double Multiplication(double number1, double number2) => number1 * number2;
       





      
    }
}
