using System;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Menu.ShowMenuOptions(); options class
            string choice = Console.ReadLine();
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
            }
        }
    }
}
