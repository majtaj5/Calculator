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
            string usreInPut = Console.ReadLine();


            List<string> numbersInput2 =  GetNumbersFromString.SplitNumbers(usreInPut);

           numbersInput2.ForEach(Console.WriteLine);
            var mat2 = 2;
            //if (usreInPutLower.Contains("per"))
            {
                
                SimpleAlgoritms simpleAlgoritms = new SimpleAlgoritms();
                simpleAlgoritms.PerfectNumber(mat2);

                if (simpleAlgoritms.PerfectNumber(mat2))
                {
                    Console.WriteLine("dupa");
                }
            }
            //else if (usreInPutLower.Contains("pow"))
            {
                Console.WriteLine("wop");
            }
        }
        void Print(string s)
        {
            Console.WriteLine(s);
        }
    }
}