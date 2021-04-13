using System;

namespace Dinsdag_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string dNA = "";
            string rNA = "";
            do
            {
                Console.WriteLine("Enter a DNA-string (consisting of only of the letters 'G','C','T' or'A'");
                dNA = Console.ReadLine();
                dNA = dNA.ToUpper();
            } while (!(dNA.Contains('G')) || !(dNA.Contains('C')) || !(dNA.Contains('T')) || !(dNA.Contains('A')));
            for (int i = 0; i < dNA.Length; i++)
            {
                if (dNA[i] == 'G')
                {
                    rNA += 'C';
                }
                if (dNA[i] == 'C')
                {
                    rNA += 'G';
                }
                if (dNA[i] == 'T')
                {
                    rNA += 'A';
                }
                if (dNA[i] == 'A')
                {
                    rNA += 'U';
                }
            }
            Console.WriteLine($"The equivalent RNA-string is {rNA}");
        }
    }
}
