using System;

namespace BecomeNeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rangen = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                int color = rangen.Next(0, 15);
                //Genereer nieuw random teken:
                char teken = Convert.ToChar(rangen.Next(62, 400));
                //Zet teken op scherm
                Console.Write(teken);

                //Ietwat vertragen
                System.Threading.Thread.Sleep(1); //dit getal is in milliseconden. Speel er gerust mee.

                //Af en toe ander kleurtje
                if (rangen.Next(0, 5) == 0)
                {
                    Console.ForegroundColor = (ConsoleColor)color;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
        }
    }
}
