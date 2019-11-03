using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            qwerty:
            Console.WriteLine("Syötä positiivinen kokonaisluku");
            int a = int.Parse(Console.ReadLine());
            int b = 1;

            if(a >= 0)
            {
                for (int i = 1; i <= a; i++)
                {
                    b = b * i;
                }
                Console.WriteLine($"Luvun tekijöiden kertoma on: {b}");

            }
            else
            {
                Console.WriteLine("Luku ei ole positiivinen kokonaisluku");
                goto qwerty;
            }
        }
    }
}
