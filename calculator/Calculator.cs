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
            Console.Clear();
            Console.WriteLine("Napisz rowaznie");
            string usreInPut = Console.ReadLine();
            string userInPutRemoveWhitespace = usreInPut.Replace(" ", "");
            char[] chars = {'+', '-', '*', '/', '\\' };
            int posChar = userInPutRemoveWhitespace.IndexOfAny(chars);
            string number1 = "";
            string number2 = "";

            for (int i = 0; i < posChar; i++)
            {
                number1 = number1 + userInPutRemoveWhitespace[i];
            }

            for (int j = posChar + 1; j < userInPutRemoveWhitespace.Length; j++)
            {
                number2 = number2 + userInPutRemoveWhitespace[j];
            }


            Console.WriteLine(number1);
            Console.WriteLine(number2);
            double number1db = double.Parse(number1);
            double number2db = double.Parse(number2);
            Console.WriteLine(number1db);
            Console.WriteLine(number2db);

            char operations = userInPutRemoveWhitespace[posChar];
            double result = 0;
            Console.WriteLine(operations);
            result = CalculatorOperations.Count(number1db, number2db, operations);
            Console.WriteLine(result);
        }

        
        
    }

















      
    
}
