using System;

namespace IfExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä 3 lukua");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            {
                int[] n = new int[3] { a, b, c };
                {
                    Array.Sort(n);
                    foreach (int value in n)
                    {
                        Console.Write(value + " ");
                    }
                }
            }




        }
    }
}
