using System;

namespace calculator
{
    public class SimpleAlgoritms
    {
        public bool PrimeNumber(int number)
        {
            double range = number / 2;
            if (number <= 1) return false;
            if (number % 2 == 0) return false;
            for (int i = 2; i <= range; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
