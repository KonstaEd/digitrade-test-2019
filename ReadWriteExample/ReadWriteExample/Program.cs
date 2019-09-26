using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample"); // Vakioviesti
            Console.Write("Moi, kirjoita nimesi: "); // Vakioviesti
            string userInput = Console.ReadLine(); // String sijoitetaan muuttuujaan userInput
            Console.WriteLine("-------------------------------------"); // Vakioviesti
            Console.WriteLine("Moi " + userInput + "!"); // Vakioviesti + arvo userInput
            Console.WriteLine("Moi {0}!", userInput); // Vakioviesti + arvo userInput (eri muoto)
            Console.WriteLine($"Moi {userInput}!"); // Tulostuksen muotoilu ja muuttujien käyttö tulostuksen yhteydessä $-merking avulla = string.Format()
        }
    }
}
