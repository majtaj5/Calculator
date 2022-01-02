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
            else if (userInPut.ToLower().Contains("pri"))
                PrimeNumberMenu(_simpleAlgorithms);
            else if (userInPut.ToLower().Contains("ave"))
                AverageOfTheNumbersMenu(_simpleAlgorithms);
            else if (userInPut.ToLower().Contains("min"))
                GetMinOfArrayMenu(_simpleAlgorithms);
            else if (userInPut.ToLower().Contains("max"))
                GetMaxOfArrayMenu(_simpleAlgorithms);
        }

        private void GetMaxOfArrayMenu(SimpleAlgoritms _simpleAlgorithms)
        {
            double[] nubers = number.Select(double.Parse).ToArray();

            if (number.Count < 2)
            {
                Console.WriteLine("You need to enter'min' and at last two numbers ");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"The maximalal Numbers is {_simpleAlgorithms.GetMaxOfArray(nubers)}");
            }
        }

        private void GetMinOfArrayMenu(SimpleAlgoritms _simpleAlgorithms)
        {
            double[] nubers = number.Select(double.Parse).ToArray();

            if (number.Count < 2)
            {
                Console.WriteLine("You need to enter'max' and at last two numbers ");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"The minimal Numbers is {_simpleAlgorithms.GetMinOfArray(nubers)}");
            }
        }

        private void AverageOfTheNumbersMenu(SimpleAlgoritms _simpleAlgorithms)
        {

            double[] nubers = number.Select(double.Parse).ToArray();
            
            if (number.Count < 2 )
            {
                Console.WriteLine("You need to enter'ave' and at last two numbers ");
                AlgorithmsChoise();
            }
            else
            {
                    Console.WriteLine($"Average Of The Numbers is {_simpleAlgorithms.AverageOfTheNumbers(nubers)}");
            }
        }

        private void PerfectNumberMenu(SimpleAlgoritms _simpleAlgoritms)
        {
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {

                Console.WriteLine("You need to enter'per' and only one integer ");
                AlgorithmsChoise();
            }
            else
            {

                if (_simpleAlgoritms.PerfectNumber(firstNumberInt))
                {
                    Console.WriteLine($"Number {firstNumberInt} is perfect number");
                }
                else
                {
                    Console.WriteLine($"Number {firstNumberInt} isn't perfect number");
                }
            }
        }

        private void PowerOfNumberMenu(SimpleAlgoritms _simpleAlgoritms)
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
                Console.WriteLine($"Power of number {firstNumberInt} is {_simpleAlgoritms.PowerOfNumber(firstNumberInt, secondtNumberInt)}"); ;
            }

        }

        private void FactorialNumberMenu(SimpleAlgoritms _simpleAlgoritms)
        {
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {
                Console.WriteLine("You need to enter 'fac' one integer");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"Factorial number of {firstNumberInt} is {_simpleAlgoritms.FactorialNumber(firstNumberInt)}"); ;
            }
        }

        private void PrimeNumberMenu(SimpleAlgoritms _simpleAlgoritms)
        {
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {
                Console.WriteLine("You need to enter 'fac' one integer");
                AlgorithmsChoise();
            }
            else
            {
                Console.WriteLine($"Prime number of {firstNumberInt} is {_simpleAlgoritms.FactorialNumber(firstNumberInt)}"); ;
            }
        }
    }


}
