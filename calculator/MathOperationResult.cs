using System;

namespace calculator
{
    class ShowResult
    {
        public void Result()
        {
            double number1, number2;
            int choice;
            Console.Write("Choice math operation: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("provide two numbers to calculate: ");
            number1 = double.Parse(Console.ReadLine());
            number2 = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Calculator calc = new Calculator();
            switch (choice)
            {
                case 1:
                    Console.WriteLine(calc.Sum(number1, number2));
                    break;
                case 2:
                    Console.WriteLine(calc.Subtraction(number1, number2));
                    break;
                case 3:
                    Console.WriteLine(calc.Division(number1, number2));
                    break;
                case 4:
                    Console.WriteLine(calc.Multiplication(number1, number2));
                    break;
            }
        }
    }
}
