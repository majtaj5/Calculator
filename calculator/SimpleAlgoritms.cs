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
    }
}
