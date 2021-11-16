using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class MainMenuOutPut
    {
        public static void ShowMenuOptions()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("0-simple calculator\n" +
                "1-advenced calculator\n" +
                "2-workinig withthe text files\n" 
                );
            Console.ResetColor();
        }
    }
}


       
