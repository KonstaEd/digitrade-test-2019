using System;

namespace LoopContinues4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa saatujen klaavojen ja kruunien määrän.");
            Console.WriteLine("Monta kertaa kolikkoa heitetään?");
            int a = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int kruuna = 0;
            int klaava = 0;

            for (int i = 1; i <=a; i++)
            {
                int heitto = rnd.Next(2);
                if (heitto < 1)
                {
                    klaava = klaava + 1;
                }
                else
                {
                    kruuna = kruuna + 1;
                }
            }
            Console.WriteLine($"Kolikkoa on heitetty {a} kertaa.\nKlaavoja tuli {klaava} ja kruunuja {kruuna}.");
        }
    }
}
