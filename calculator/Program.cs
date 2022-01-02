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
                  "Power of number- Type 'pow' and base number with exponent of power For example: pow 6\n" +
                  "Factorial number- Type 'fac' and number For example: pre 6\n" +
                  "Prime number- Type 'pri' and number For example: pri 6\n" +
                  "Average of the numbers- Type 'ave' and numbers For example: ave 6 3,3 3\n" +
                  "Get min of array- Type 'min' and numbers For example: min 6 3,3 3\n" +
                  "Get max of array- Type 'max' and numbers For example: max 6 3,3 3\n"
                  );
                        SimpleAlgoritms alg = new SimpleAlgoritms();
                        SimpleAlgoritmsMenu algMenu = new SimpleAlgoritmsMenu(alg);
                        algMenu.AlgorithmsChoise();

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
