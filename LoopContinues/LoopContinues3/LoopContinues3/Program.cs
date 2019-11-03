using System;

namespace LoopContinues3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50");
            Random rnd = new Random();

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Rivi {i}: ");
                for (int k = 1; k <= 5; k++)
                {
                    int j = rnd.Next(51);
                    if (k < 5)
                    Console.Write($"{j}, ");
                    else
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
