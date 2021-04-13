using System;
using System.Collections.Generic;
namespace Euler_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString;
            do
            {
                Console.WriteLine("Please enter a number for the Euler project");
                numberString = Console.ReadLine();
            } while (!(Microsoft.VisualBasic.Information.IsNumeric(numberString)));

            int eulerNumber = Convert.ToInt32(numberString);
            int sum = 0;
            List<int> veelvouden = new List<int>();

            for (int i = 2; i <= eulerNumber; i++)
            {
                if ((i % 3 == 0) && (i % 5 != 0))
                {
                    veelvouden.Add(i);
                }
                else if (i % 5 == 0)
                {
                    veelvouden.Add(i);
                }

            }
            int[] veelvoudenArray = veelvouden.ToArray();
            foreach (int number in veelvoudenArray)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of all the multiples of 3 and 5, below {eulerNumber} is {sum}");
        }
    }
}
