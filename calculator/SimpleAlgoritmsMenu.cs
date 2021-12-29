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

            string userInPut = Console.ReadLine();

            List<string> number = userInPut.SplitNumbers();
            
            int firstNumberInt = 0;
            if (number.Count != 1 || !int.TryParse(number[0], out firstNumberInt))
            {
                Console.Clear();
                Console.WriteLine("You need to enter only one integer ");
                AlgorithmsChoise();
            }
            else
            {

                if (userInPut.ToLower().Contains("per"))
                {

                    SimpleAlgoritms simpleAlgoritms = new SimpleAlgoritms();
                    simpleAlgoritms.PerfectNumber(firstNumberInt);

                    if (simpleAlgoritms.PerfectNumber(firstNumberInt))
                    {
                        Console.WriteLine($"Number {firstNumberInt} is perfect number");
                    }
                    else
                    {
                        Console.WriteLine($"Number {firstNumberInt} isn't perfect number");
                    }
                }
                else if (userInPut.ToLower().Contains("pow"))
                {
                    Console.WriteLine("wop");
                }
            }

        }

    }
}