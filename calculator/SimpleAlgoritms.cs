using System;

namespace calculator
{
    public class SimpleAlgoritms
    {
        public static bool PrimeNumber(int number)
        {
            double range = number / 2;
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= range; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
