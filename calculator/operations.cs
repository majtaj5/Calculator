using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class operations
    {


        public static void GetCalculationType()
        {
            Console.WriteLine($"{Environment.NewLine}Choose a calculation type from the list below: ");

            string[] letersForCalculator = { "A for Addition", "B for Subtraction", "C for Multiplication", "D for Division" };

            foreach (string v in letersForCalculator) 
            {
                Console.WriteLine(v);
            }


        }



    }
}
