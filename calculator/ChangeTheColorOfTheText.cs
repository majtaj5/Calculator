﻿using System;
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
            Console.ResetColor();
        }
    }
            
}
