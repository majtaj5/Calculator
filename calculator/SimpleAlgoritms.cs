namespace calculator
{
    using System;
    public class SimpleAlgoritms
    {
        public bool PrimeNumber(int number)
        {
            double range = number / 2;
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            for (int i = 3; i < range; i++)
            {
                if (number % i == 0)
                {  
                    return false;
                }
                Console.WriteLine(number % i);
            }
            return true;
        }
        public int FactorialOfNumber(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        public int PowerOfNumber(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
        public int AverageOfTheNumbers(int [] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result / numbers.Length;
        }
        public int[] MinMaxElementOfArray(int[] numbers)
        {
            int n = numbers.Length;
            while (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
                n--;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

    }
}



