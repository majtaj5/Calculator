namespace calculator
{
using System;


    public class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("What math operation to perform?\n1. Sum.\n2. Subtraction.\n3. Diviosion.\n4. Multiplication.");
            
            int number = int.Parse(Console.ReadLine());
            

            if (number == 1)
            {
                Console.WriteLine(Sum()); 
            }
            else if (number == 2)
            {
                Console.WriteLine(Subtraction());
            }
            else if (number == 3)
            {
                Console.WriteLine(Division());
            }
            else if (number == 4)
            {
                Console.WriteLine(Multiplication());
            }
            

        }

        private int Sum()
        {
            Console.WriteLine("Enter two numbers for the sum: ");
            int number1, number2;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            return number1 + number2;
 
        }
        private int Subtraction()
        {
            Console.WriteLine("Enter two numbers for the subtract: ");
            int number1, number2;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            return number1 - number2;
        }
        private double Division()
        {
            Console.WriteLine("Enter two numbers to divide: ");
            double number1, number2;
            number1 = double.Parse(Console.ReadLine());
            number2 = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            return Math.Round(number1 / number2, 2);
        }
        private int Multiplication()
        {
            Console.WriteLine("Enter two numbers to multiply: ");
            int number1, number2;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            return number1 * number2;
        }
}
}


