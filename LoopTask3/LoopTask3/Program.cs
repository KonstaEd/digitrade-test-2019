﻿using System;

namespace LoopTask3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan.");
            Console.Write("Syötä luku: ");
            int a = int.Parse(Console.ReadLine());
        int evenSum = 0;
        int oddSum = 0;

            if (a >= 0)
            {
                for (int i = 0; i <= a; i++)
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i;
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                Console.WriteLine($"Parillisten summa = {evenSum}\nParittomien summa = {oddSum}");
            }
            else
            {


                for (int i = 0; i <= a * -1; i++)
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum + i;
                    }
                    else
                    {
                        oddSum = oddSum + i;
                    }
                Console.WriteLine($"Parillisten summa = {evenSum}\nParittomien summa = {oddSum}");
            }
        }
    }
}
