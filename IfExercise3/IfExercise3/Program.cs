using System;

namespace IfExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Syötä numero");
            number = int.Parse(Console.ReadLine());
            if (number == 0) Console.WriteLine("Numero " + number + " on nolla");
            else if (number < 0)
            {
                if (number % 2 == 0) Console.WriteLine("Numero " + number + " on negatiivinen ja parillinen");
                else
                {
                    Console.WriteLine("Numero " + number + " on negatiivinen ja pariton");
                }
            }
            else if (number > 0)
            {
                if (number % 2 == 0) Console.WriteLine("Numero " + number + " on poistiivinen ja parillinen");
                else
                {
                    Console.WriteLine("Numero " + number + " on positiivinen ja pariton");
                }

            }
        }
    }
}
