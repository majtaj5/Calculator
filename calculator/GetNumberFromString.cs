namespace calculator
{
    public static class GetNumberFromString
    {
        public static CalculatorNumbers NumberFromString(int position, string userInput)
        {
            CalculatorNumbers o = new CalculatorNumbers();

            for (int i = 0; i < position; i++)
            {
                o.number1 = o.number1 + userInput[i];
            }

            for (int j = position + 1; j < userInput.Length; j++)
            {
                o.number2 = o.number2 + userInput[j];
            }
            return o;
        }
    }
}
