namespace calculator

{
class Calculator
{

    //public void Choice()
    //    {
    //        System.Console.WriteLine("Wybierz gre: 1. \n2. \n 3. \n 4. \n");
    //    }
    public static int Sum(params int [] numbers)
    {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
    }

    public static int Subtraction(int a, int b)
    {
        return a - b;
    }
    public static int Division(int a, int b)
    {
        return a / b;
    }
    public static int Multiplication(int a, int b)
    {
        return a * b;
    }
}
}


