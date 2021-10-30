using System;


namespace calculator
{
    partial class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("W co chcesz zagrac? \n1. \n2. \n3. \n4. \n ");
            int choice;
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Calculator test = new Calculator();
            }
            else if (choice == 2)
            {
                Console.WriteLine("test2");
            }
            else if (choice == 3)
            {
                Console.WriteLine("test3");
            }
            else if (choice == 4)
            {
                Console.WriteLine("test4");
            }

            Console.ReadKey();
            }
        }
    }

