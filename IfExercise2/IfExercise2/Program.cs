using System;

namespace IfExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Syötä numero");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0) Console.WriteLine("Numero " + number + " on parillinen");
            else
            {
                Console.WriteLine("Numero " + number + " on pariton");
            }

        }
    }
}
