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
        public int PowerOfNumber(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++) result *= number;
            return result;
        }
    }
}
