using System;

namespace ForDoordenker
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString;
            do
            {
                Console.WriteLine("give a maximum");
                numberString = Console.ReadLine();
            } while (!(Microsoft.VisualBasic.Information.IsNumeric(numberString)));
            int maximum = Convert.ToInt32(numberString);

            for (int i = 0; i < maximum; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
            for (int i = maximum; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
