using System;


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
                    Console.WriteLine("dupa");

                    break;
                case ("1"):
                    Console.WriteLine("dupa");

                    break;
                case ("2"):
                    Console.WriteLine("dupa");

                    break;
                case ("3"):  //power

                    Power power = new Power();
                    Console.WriteLine(power.GetPower(2, 8));

                    break;

                case ("4"):
                    Console.WriteLine("dupa");

                    break;
                case ("5"):
                    Console.WriteLine("dupa");

                    break;
                case ("6"):
                    Console.WriteLine("dupa");

                    break;


            }

            



            Console.ReadLine();
   
        }
    }
}
