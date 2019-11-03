using System;

namespace LoopContinues5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkausrivin 13 kohdetta");

            for(int i = 1; i <= 13; i++)    
            {
                Random rnd = new Random();
                double a = rnd.NextDouble();
                {
                    if (a <= 0.4)
                    {
                        Console.WriteLine($"{i}. 1");
                    }
                    else if (a > 0.4 && a < 0.6)
                    {
                        Console.WriteLine($"{i}. X");
                    }
                    else
                    {
                        Console.WriteLine($"{i}. 2");
                    }
                }
            }
        }
    }
}
