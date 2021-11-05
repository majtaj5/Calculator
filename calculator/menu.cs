using System;

namespace calculator
{
    class Menu
    {



        public static void ShowMenuOptions()

        {

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What would you like to do?");
            string[] mainoptions = { "0 - simple calculator", "1 - advanced calculator" , "2 - working with the text files" };

            foreach (string userInput in mainoptions)
            {

                Console.WriteLine(userInput);

            }




            
            Console.ResetColor();
        }
       
    }
}
