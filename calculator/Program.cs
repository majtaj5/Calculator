using System;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            AplicationMenus menu = new AplicationMenus();
            Calculator calc = new Calculator();
            SimpleAlgoritms alg = new SimpleAlgoritms();
            ShowResult result = new ShowResult();
            Console.WriteLine(menu.MathOperationsMenu());
            result.Result();
            Console.ResetColor();
            Console.ReadKey();
            }
        }
    }

