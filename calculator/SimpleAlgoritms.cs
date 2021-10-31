namespace calculator
{
    using System;
    public class SimpleAlgoritms
    {
        public SimpleAlgoritms()
        {
            //ctorialOfNumber();
            //FactorialOfNumber();
            //PowerOfNumber();
            AverageOfTheNumbers();
        }
        private void PrimeNumber()
        {
            int number;
            Console.Write("Number to chech: ");
            number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            if (number % 2 == 1 || number % 3 == 1)
            {
                Console.WriteLine("It's prime number.");
            }
            else
            {
                Console.WriteLine("It is not prime number.");
            }
            Console.ResetColor();
        }
        private void FactorialOfNumber()
        {
            int factorialNumber;
            Console.Write("Factorial of the number to calculate: ");
            factorialNumber = int.Parse(Console.ReadLine());
            for (int i = factorialNumber - 1; i > 0; i--)
            {
                factorialNumber *= i;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(factorialNumber);
            Console.ResetColor();
        }
        private void PowerOfNumber()
        {
            int powerOfNumber;
            Console.Write("The power of number to calculate: ");
            powerOfNumber = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(powerOfNumber *= powerOfNumber);
            Console.ResetColor();
        }
        private void AverageOfTheNumbers()
        {
            int[] numbers = new int[5];
            int input;
            Console.WriteLine("Insert 5 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                input = int.Parse(Console.ReadLine());
                numbers[i] = input;
            }
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine($"Srednia podanych liczb: {sum / numbers.Length}");
        }

    }
}



