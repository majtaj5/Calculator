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
        private List<string> number;
        private readonly SimpleAlgoritms _simpleAlgorithms;
        public SimpleAlgoritmsMenu(SimpleAlgoritms simpleAlgoritms)
        {
            _simpleAlgorithms = simpleAlgoritms;
        }
        public void AlgorithmsChoise()
        {
            
            string userInPut = Console.ReadLine();

            number = userInPut.SplitNumbers();
           
            if (userInPut.ToLower().Contains("per"))
                PerfectNumberMenu(_simpleAlgorithms);
            else if (userInPut.ToLower().Contains("pow"))
                PowerOfNumberMenu(_simpleAlgorithms);
            else if (userInPut.ToLower().Contains("fac"))
                FactorialNumberMenu(_simpleAlgorithms);
            else if (userInPut.ToLower().Contains("fac"))
                PrimeNumberMenu(_simpleAlgorithms);
        }

        private void PerfectNumberMenu(SimpleAlgoritms simpleAlgoritms)
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

        private void PowerOfNumberMenu(SimpleAlgoritms simpleAlgoritms)
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

        private void FactorialNumberMenu(SimpleAlgoritms simpleAlgoritms)
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

        private void PrimeNumberMenu(SimpleAlgoritms simpleAlgoritms)
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
