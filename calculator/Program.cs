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
                switch (choice)
                {
                    case ("0"):
                        ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.Blue,
                  "Type the equation you want to calculate.\n" +
                  "You can add, subtract, multiply, divide two numbers.\n" +
                  "\n" +
                  "For example:\n" +
                  "2+2\n" +
                  "2*2\n"
                  );
                        CalculatorNumbers cal = new CalculatorNumbers();
                        Calculator calculator = new Calculator(cal);
                        calculator.Calculate();
                        Console.ReadLine();

                        break;
                    case ("1"):
                        ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.Blue,
                  "Perfect number- Type 'per' and number For example: per 6\n" +
                  "Power of number- Type 'pow' and number For example: pre 6\n" +
                  "Factorial number\n" +
                  "Prime number\n" +
                  "Average of the numbers\n" +
                  "Get min of array\n"+
                  "Get max of array\n"
                  );
                        SimpleAlgoritmsMenu.AlgorithmsChoise();
                        Console.ReadLine();
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
