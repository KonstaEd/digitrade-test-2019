using System;

namespace LoopContinues2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9");

            Console.WriteLine("Kertotaulut");
            for (int i = 1; i < 10; i++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine($"{i} * {a} = {i * a}");
                }
            }
        }
    }
}
