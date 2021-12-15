using System;


namespace calculator
{
    public class Calculator : BaseCalculator
    {
        private readonly CalculatorNumbers _calculatorNumbers;
        public Calculator (CalculatorNumbers calculatorNumbers)
        {
            _calculatorNumbers = calculatorNumbers;
        }

        public void Calculate()
        {

            string usreInPut = Console.ReadLine();

            string userInPutRemoveWhitespace = usreInPut.Replace(" ", "");

            char[] mathSymbols = { '+', '-', '*', '/', '\\' };
            int posChar = userInPutRemoveWhitespace.IndexOfAny(mathSymbols);

            var b = NumberFromString(posChar, userInPutRemoveWhitespace);

            double number1db = double.Parse(b.number1);
            double number2db = double.Parse(b.number2);

            char operations = userInPutRemoveWhitespace[posChar];

            double result = 0;
            result = Count(number1db, number2db, operations);
            ChangeTheColorOfTheText.PrintColorMessage(ConsoleColor.DarkCyan, $"Your result: {result}");
        }

        private CalculatorNumbers NumberFromString(int position, string userInput)
        {
            for (int i = 0; i < position; i++)
            {
                _calculatorNumbers.number1 = _calculatorNumbers.number1 + userInput[i];
            }

            for (int j = position + 1; j < userInput.Length; j++)
            {
                _calculatorNumbers.number2 = _calculatorNumbers.number2 + userInput[j];
            }
            return _calculatorNumbers;
        }

        private double Count(double number1db, double number2db, char operations)
        {
            double result = 0;

            switch (operations)
            {
                case '+':
                    result = Addition(number1db, number2db);
                    break;
                case '-':
                    result = Subtraction(number1db, number2db);
                    break;
                case '*':
                    result = Multiplication(number1db, number2db);
                    break;
                case '/':
                case '\\':
                    result = Division(number1db, number2db);
                    break;
            }
            return result;
        }
    }
}
