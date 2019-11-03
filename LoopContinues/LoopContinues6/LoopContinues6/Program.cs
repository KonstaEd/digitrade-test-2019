using System;

namespace LoopContinues6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi nopan heittoa 1000 kertaa ja tulostaa lisäksi kuutosen esiintymiskertojen lukumäärän");
            int k = 0;

            for (int i = 1; i <= 1000; i++)
            {
                Random rnd = new Random();
                int heitto =rnd.Next(6);
                if (heitto > 4)
                {
                    k += 1;
                }
                Console.WriteLine($"{i}. {heitto+1}");
            }
            Console.WriteLine($"\nKuutonen arvottiin {k} kertaa.");
        }
    }
}
