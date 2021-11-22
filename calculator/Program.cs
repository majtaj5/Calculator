using System;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MainMenuOutPut.ShowMenuOptions();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case ("0"):
                    Calculator.Calculate();
                    break;
                case ("1"):
                    Console.WriteLine("menu-SimpleAlgoritms");
                    break;
                case ("2"):
                    Console.WriteLine("menu-working with text");
                    break;
            }
        }
    }
}
