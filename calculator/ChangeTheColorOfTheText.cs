using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class ChangeTheColorOfTheText
    {
        public static void PrintColorMessage(ConsoleColor color, string message)
        { 
            Console.ForegroundColor = color;

            Console.WriteLine(message);
            //Console.ResetColor does not work .I don't know why .I created a method that resets color. Error CS0201  Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement calculator  
            resetConsole();
        }

        private static void resetConsole()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        }
            
}
