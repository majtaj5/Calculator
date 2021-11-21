using System;

namespace calculator
{
    public class Calculator
    {
        int numer1 = 0;
        int numer2 = 0;
        string menuCalculator = ("What would you like to do?\n" +
            "0-Subtraction\n" +
            "1-Addition\n" +
            "2-Division\n" +
            "2-Multiplication\n"
            );






                );


        ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.DarkGreen, menuCalculator);
        public static void SwithStatementforCalculator()
        { 

         switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Result: {Subtraction});
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1* num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;

            }

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
        public double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
