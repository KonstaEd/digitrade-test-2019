using System;

namespace IfExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Syötä numero");
            number = int.Parse(Console.ReadLine());
            if (number == 0) Console.WriteLine("Numero " + number + " on nolla");
            else if (number < 0) Console.WriteLine("Numero " + number + " on negatiivinen");
            else if (number > 0) Console.WriteLine("Numero " + number + " positiivinen");
        }
    }
}
