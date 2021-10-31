namespace calculator
{
    using System;
    public class SimpleAlgoritms
    {
        static void LiczbyPierwsze(int liczbaProb)
        {
            int licznik = 0;
            int liczba = 2;
            //Console.WriteLine("Podaj liczbe prob: ");
            //liczbaProb = int.Parse(Console.ReadLine());
            while ((licznik = int.Parse(Console.ReadLine())) < liczbaProb)
            {
                liczba++;
                if (liczba % 2 == 1)
                {
                    Console.WriteLine(liczba);
                    licznik++;
                }
                else
                    continue;

            }
        }

    }
}

