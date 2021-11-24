using System;


namespace calculator
{
    public class  Calculator
    {
        public static void Calculate()
        {
            //write text and read user input
            ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.DarkBlue,
                "Type the equation you want to calculate.\n" +
                "You can add, subtract, multiply, divide two numbers.\n" +
                "\n" +
                "For example:\n"+
                "2+2\n"+
                "2*2\n"
                );
            string usreInPut = Console.ReadLine();

            //removing spaces from a string
            string userInPutRemoveWhitespace = usreInPut.Replace(" ", "");

            //getting index of a math symbol
            char[] mathSymbols = {'+', '-', '*', '/', '\\' };
            int posChar = userInPutRemoveWhitespace.IndexOfAny(mathSymbols);

            string number1 = "";
            string number2 = "";

            //getting nembers from a string
            for (int i = 0; i < posChar; i++)
            {
                number1 = number1 + userInPutRemoveWhitespace[i];
            }

            for (int j = posChar + 1; j < userInPutRemoveWhitespace.Length; j++)
            {
                number2 = number2 + userInPutRemoveWhitespace[j];
            }

            //parsing numbers to double
            double number1db = double.Parse(number1);
            double number2db = double.Parse(number2);

            //getting a math symbol
            char operations = userInPutRemoveWhitespace[posChar];

            //printing out the result
            double result = 0;
            result = CalculatorOperations.Count(number1db, number2db, operations);
            ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.DarkCyan, $"Your result: {result}");
        }
    } 
}
