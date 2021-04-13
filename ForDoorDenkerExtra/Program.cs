using System;

namespace ForDoorDenkerExtra
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
            int i = maximum;

            for (int j = 0; j < maximum; j++)
            {
                for (int k = -8; k <= i; k++)
                {
                    Console.Write(" ");
                }

                for (int l = 0; l < j; l++)
                {
                    Console.Write("**");
                }

                Console.Write("*");
                Console.WriteLine("");
                i--;
            }
        }
    }
}
