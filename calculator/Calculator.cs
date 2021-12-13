using System;


namespace calculator
{
    public class Calculator : BaseCalculator
    {
        public static void Calculate()
        {
            
            string usreInPut = Console.ReadLine();

            string userInPutRemoveWhitespace = usreInPut.Replace(" ", "");

            char[] mathSymbols = { '+', '-', '*', '/', '\\' };
            int posChar = userInPutRemoveWhitespace.IndexOfAny(mathSymbols);

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

            double number1db = double.Parse(number1);
            double number2db = double.Parse(number2);

            char operations = userInPutRemoveWhitespace[posChar];

            double result = 0;
            result = Count(number1db, number2db, operations);
            ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.DarkCyan, $"Your result: {result}");

        }

        private static double Count(double number1db, double number2db, char operations)
        {
            double result = 0;

            switch (operations)
            {
                case '+':
                    result = Addition(number1db, number2db);
                    break;
                case '-':
                    result = Subtraction(number1db, number2db);
                    break;
                case '*':
                    result = Multiplication(number1db, number2db);
                    break;
                case '/':
                case '\\':
                    result = Division(number1db, number2db);
                    break;
            }
            return result;
        }
    }
}
