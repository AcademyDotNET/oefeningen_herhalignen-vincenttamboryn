using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberString;
            do {
                Console.WriteLine("Please enter a number, to check if it is an armstrong number");
                numberString = Console.ReadLine();
            } while (!(Microsoft.VisualBasic.Information.IsNumeric(numberString)));
            IsArmstrong(numberString);
        }
        static void IsArmstrong(string armNumber)
        {
            double sum = 0;
            double armstrongNumber = Convert.ToDouble(armNumber);
            foreach (char v in armNumber)
            {
                string c = Convert.ToString(v);
                int digit = Convert.ToInt32(c);
                sum += Math.Pow(digit, armNumber.Length);
            }

            if (sum == armstrongNumber)
            {
                Console.WriteLine($"{armNumber} is an armstrong number");
            }
            else
            {
                Console.WriteLine($"{armNumber} is not an armstrong number. {armstrongNumber}!={sum}");
            }
        }
    }
}
