using System;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            bool appOn = true;
            while (appOn)
            {
                MainMenuOutPut.ShowMenuOptions();
                string choice = Console.ReadLine();
                
                ConsoleKey cki;
                Console.TreatControlCAsInput = true;
                cki = Console.ReadKey();
                KeyNavigation.PressedKey(cki);


                switch (choice)
                {
                    case ("0"):
                        //operations.GetCalculationType();
                        Console.WriteLine("menu-Calculator");
                        break;
                    case ("1"):
                        Console.WriteLine("menu-SimpleAlgoritms");
                        break;
                    case ("2"):
                        Console.WriteLine("menu-working with text");
                        break;
                    case ("3"):
                        appOn = false;
                        break;
                }
            }
        }
    }
}
