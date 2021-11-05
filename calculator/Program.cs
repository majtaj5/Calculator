using System;
using calculator.Enums;

namespace calculator
{
    partial class Program
    {
        
        static void Main(string[] args)
        {
            Menu.ShowMenuOptions();
            string choice = (Console.ReadLine());
            

            switch (choice)
            {

                case ("0"):

                    operations.GetCalculationType();
                    break;
                case ("1"):
                    Console.WriteLine("dupa");

                    break;
                case ("2"):
                    Console.WriteLine("dupa");

                    break;
                


            }

            



            Console.ReadLine();
   
        }
    }
}
