using System;

namespace lipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            int price = 16;
            Console.WriteLine("Syötä ikäsi");
            age = int.Parse(Console.ReadLine());
            if (age > 6 && age < 16) Console.WriteLine("Hinta on " + price * (0.5));
            else if (age < 7) Console.WriteLine("Hinta on 0");
            else if (age >= 65) Console.WriteLine("Hinta on " + price * (0.5));



            else
            {
                Console.WriteLine("Oletko jotain seuraavista? Syötä numero \n 1. Opiskelija \n 2. Varusmies \n 3. Mtk jäsen \n 4. Opiskelija sekä mtk jäsen \n 5. En mikään edeletävistä");
                string input = (Console.ReadLine());
                switch (input.ToLower())
                {
                    case "1":
                        Console.WriteLine("Hinta on " + price * (0.65));
                        break;
                    case "2":
                        Console.WriteLine("Hinta on " + price * (0.5));
                        break;
                    case "3":
                        Console.WriteLine("Hinta on " + price * (0.85));
                        break;
                    case "4":
                        Console.WriteLine("Hinta on " + price * (0.4));
                        break;
                    case "5":
                        Console.WriteLine("Hinta on " + price);
                        break;



                }
            }
        }
    }
}
