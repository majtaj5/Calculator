namespace calculator
{
    public static class GetNumberFromString
    {
        public static CalculatorNumbers NumberFromString(int position, string userInput)
        {
            CalculatorNumbers calculatorNumbers = new CalculatorNumbers();

            for (int i = 0; i < position; i++)
            {
                calculatorNumbers.number1 = calculatorNumbers.number1 + userInput[i];
            }

            for (int j = position + 1; j < userInput.Length; j++)
            {
               calculatorNumbers.number2 = calculatorNumbers.number2 + userInput[j];
            }
            return calculatorNumbers;
        }
    }
}