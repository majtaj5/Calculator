using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calculator
{
    public class SimpleAlgoritmsMenu
    {
        
        public static void AlgorithmsChoise()
        {
            SimpleAlgoritms simpleAlgoritms = new SimpleAlgoritms();

            string userInPut = Console.ReadLine();

            List<string> number = userInPut.SplitNumbers();
           
            if (userInPut.ToLower().Contains("per"))
                PerfectNumberMenu(simpleAlgoritms, number);
            else if (userInPut.ToLower().Contains("pow"))
                PowerOfNumberMenu(simpleAlgoritms, number);
            else if (userInPut.ToLower().Contains("fac"))
                FactorialNumberMenu(simpleAlgoritms, number);
            else if (userInPut.ToLower().Contains("fac"))
                PrimeNumberMenu(simpleAlgoritms, number);
        }

        private static void PerfectNumberMenu(SimpleAlgoritms simpleAlgoritms, List<string> number)
        {
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {

                Console.WriteLine("You need to enter'per' and only one integer ");
                AlgorithmsChoise();
            }
            else
            {

                if (simpleAlgoritms.PerfectNumber(firstNumberInt))
                {
                    Console.WriteLine($"Number {firstNumberInt} is perfect number");
                }
                else
                {
                    Console.WriteLine($"Number {firstNumberInt} isn't perfect number");
                }
            }
        }

        private static void PowerOfNumberMenu(SimpleAlgoritms simpleAlgoritms, List<string> number)
        {
            double firstNumberInt = 0;
            int secondtNumberInt = 0;
            if (number.Count != 2 || !double.TryParse(number[0], out firstNumberInt) || !int.TryParse(number[1], out secondtNumberInt))
            {
                Console.WriteLine("You need to enter'pow' and one double and one integer");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"Power of number {firstNumberInt} is {simpleAlgoritms.PowerOfNumber(firstNumberInt, secondtNumberInt)}"); ;
            }

        }

        private static void FactorialNumberMenu(SimpleAlgoritms simpleAlgoritms, List<string> number)
        {
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {
                Console.WriteLine("You need to enter 'fac' one integer");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"Factorial number of {firstNumberInt} is {simpleAlgoritms.FactorialNumber(firstNumberInt)}"); ;
            }
        }

        private static void PrimeNumberMenu(SimpleAlgoritms simpleAlgoritms, List<string> number)
        {
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {
                Console.WriteLine("You need to enter 'fac' one integer");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"Prime number of {firstNumberInt} is {simpleAlgoritms.FactorialNumber(firstNumberInt)}"); ;
            }
        }
    }


}
