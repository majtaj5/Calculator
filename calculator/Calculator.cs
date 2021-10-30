namespace calculator
{
using System;


    class Calculator
    {
        public Calculator()
        {
            Gra();
            int number = int.Parse(Console.ReadLine());

            if (Choice(number) == 1)
            {
                Console.WriteLine(Sum()); 
            }
            else if (Choice(number) == 2)
            {
                Console.WriteLine(Subtraction());
            }
            else if (Choice(number) == 3)
            {
                Console.WriteLine(Division());
            }
            else if (Choice(number) == 4)
            {
                Console.WriteLine(Multiplication());
            }

        }
        public void Gra()
        {
            Console.WriteLine("Dzialanie do wykonania: ");
        }
        public int Choice(int choice)
        {
            return choice;
        }

        public int Sum()
        {
             Console.WriteLine("Podaj dwie liczby do sumy: ");
             int number1, number2, sum = 0;
             number1 = int.Parse(Console.ReadLine());
             number2 = int.Parse(Console.ReadLine());
             return number1 + number2;
 
        }

        public static int Subtraction()
        {
            Console.WriteLine("Podaj dwie liczby do roznicy: ");
            int number1, number2, sum = 0;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            return number1 - number2;
        }
        public static int Division()
        {
            Console.WriteLine("Podaj dwie liczby do dzielenia: ");
            int number1, number2, sum = 0;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            return number1 / number2;
        }
        public static int Multiplication()
        {
            Console.WriteLine("Podaj dwie liczby do mnozenia: ");
            int number1, number2, sum = 0;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            return number1 * number2;
        }
}
}


