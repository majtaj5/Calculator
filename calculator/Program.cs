using System;


namespace calculator
{
    partial class Program
    {
        
        static void Main(string[] args)
        {
            //Calculator choice = new Calculator();
            //string a = choice.Choice();
            int number1, number2, sum;
            Console.WriteLine("Podaj dwie liczby calkowite: ");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            sum = Calculator.Sum(number1, number2);
            Console.WriteLine($"Suma liczb {number1} oraz {number2} wynosi: {sum}");

            Console.WriteLine("Wybierz gre 1,2,3,4");

 

            Console.ReadKey();
        }
    }
}
