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
            string[] mainoptions = { "0 - simple calculator", "1 - advanced calculator", "2 - working with the text files" };

            foreach (string userInput in mainoptions)
            {
                Console.WriteLine(userInput);
            }
            Console.ResetColor();
        }
    }
}


       
