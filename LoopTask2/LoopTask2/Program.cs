using System;

namespace LoopTask2
{
    class Program
    {
        static void Main(string[] args)
        {
        qwerty:
            Console.WriteLine("Syötä positiivinen kokonaisluku");
            int a = int.Parse(Console.ReadLine());
            int b = 0;

            if (a > 0)
            {
                for (int i = 0; i <= a; i++)
                {
                    b = b + i;
                }
                Console.WriteLine($"Luvun tekijöiden summa on: {b}");

            }
            else
            {
                Console.WriteLine("Luku ei ole positiivinen kokonaisluku");
                goto qwerty;
            }
        }
    }
}
