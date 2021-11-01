using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class InputMainChoice
    {


       
        public static string GetMainChoice()
            
        { 

            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("0-simple calculator\n" +
                "1-factorial\n" +
                "2-a perfect number\n" +
                "3-power\n" +
                "4-mean value from the table\n" +
                "5-the largest and the smallest number from the table\n" +
                "6-working with the text files"
                );
            Console.ResetColor();
            string choice = Console.ReadLine();

            

            return choice;    
          }
       
    }
}
