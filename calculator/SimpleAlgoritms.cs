using System;

namespace calculator
{
    public class SimpleAlgoritms
    {
        public bool PerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number ? true : false;
        }

        public double PowerOfNumber(double number, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++) result *= number;
            return result;
        }

        public int FactorialNumber(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++) result *= i;
            return result;
        }

        public bool PrimeNumber(int number)
        {
            bool isPrime = true;
            if (number <= 1) return false;
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                return true;
            return isPrime;
        }

        public double AverageOfTheNumbers(int[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++) result += numbers[i];
            return Math.Round(result / numbers.Length, 2);
        }

        private int[] GetSortedArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int tempValue = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = tempValue;
                    }
                }
            }
            return numbers;
        }

        public int GetMinOfArray(int[] numbers)
        {
            GetSortedArray(numbers);
            return numbers[0];
        }

        public int GetMaxOfArray(int[] numbers)
        {
            GetSortedArray(numbers);
            return numbers[numbers.Length - 1];
        }

    }
}
