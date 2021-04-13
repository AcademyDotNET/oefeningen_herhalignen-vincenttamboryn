using System;
using System.Windows.Input;

namespace Boekhouder
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sumPositive = 0;
            double sumNegative = 0;
            double mean = 0;
            int iterations = 1;
            double number;
            do
            {
                //asking for a new number
                number = GetNumber();

                //increasing/decreasing the positive/negative total
                if (number >= 0)
                {
                    sumPositive += number;
                }
                else if (number < 0)
                {
                    sumNegative += number;
                }

                //increasing/decreasing the total sum
                sum += number;

                //changing mean value
                if (mean == 0 && iterations == 1)
                {
                    mean = NextMean(0, number, iterations);
                }
                else
                {
                    mean = NextMean(mean, number, iterations);
                }

                //iterations keeps track of how many times this loop has "looped"
                iterations++;
                Console.WriteLine($"Sum = {sum}");
                Console.WriteLine($"Sum of all positive entries = {sumPositive}");
                Console.WriteLine($"Sum of all negative entries = {sumNegative}");
                Console.WriteLine($"Mean = {mean}");

            } while (number != 0);
        }
        static double GetNumber()
        {
            string numberString;
            do
            {
                Console.WriteLine("Enter a positive or negative number, 0 to end the program");
                numberString = Console.ReadLine();
            } while (!(Microsoft.VisualBasic.Information.IsNumeric(numberString)));
            double number = Convert.ToDouble(numberString);
            return number;
        }
        static double NextMean(double previousMean, double newNumber, int totalNumbers)
        {
            double mean;
            mean = (previousMean * (totalNumbers - 1) + newNumber) / totalNumbers;
            return mean;
        }
        
    }
}
