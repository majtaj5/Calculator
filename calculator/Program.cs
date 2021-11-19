using System;


namespace calculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var test = new SimpleAlgoritms();
            bool a = test.PrimeNumber(7);
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
