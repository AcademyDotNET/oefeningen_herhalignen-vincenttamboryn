using System;

namespace ExtraDeel1
{
    class Program
    {
        static void Main(string[] args)
        {
            HowManyDigits();
        }
        static double GiveNumber(string test, string question)
        {
            string numberString;
            do
            {
                Console.WriteLine(question);
                numberString = Console.ReadLine();
            } while (!(Microsoft.VisualBasic.Information.IsNumeric(numberString)));
            double number = Convert.ToDouble(numberString);
            if (test == "+")
            {
                if (number >= 0)
                {
                    return number;
                }
                else
                {
                    number = GiveNumber("+", question);
                    return number;
                }
            }
            else if (test == "-")
            {
                if (number < 0)
                {
                    return number;
                }
                else
                {
                    number = GiveNumber("+", question);
                    return number;
                }
            }
            else if (test == "int")
            {
                char[] komma = { ',' };
                if (numberString.IndexOfAny(komma) == -1)
                {
                    return number;
                }
                else
                {
                    number = GiveNumber("int", question);
                    return number;
                }
            }
            else
            {
                return number;
            }

        }
        static void PrintAllNaturalsUntil()
        {
            int natural = Convert.ToInt32(GiveNumber("+", "Give a number, i'll type that many naturals, starting from 1"));
            for (int i = 0; i <= natural; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintAllNaturalsStartingFrom()
        {
            int natural = Convert.ToInt32(GiveNumber("+", "Give a number, i'll type that many naturals, starting from that number"));
            for (int i = natural; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintAllEvenNumbers()
        {
            int number = Convert.ToInt32(GiveNumber("+", "Give a number, i'll type all the even numbers between 1 and that number"));
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void PrintAllUnevenNumbers()
        {
            int number = Convert.ToInt32(GiveNumber("+", "Give a number, i'll type all the uneven numbers between 1 and that number"));
            for (int i = 1; i <= number; i++)
            {
                if (!(i % 2 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void SumOfAllNaturals()
        {
            int natural = Convert.ToInt32(GiveNumber("+", "Give a number, i'll tell you the sum of all naturals until that number"));
            double sum = (1 + natural)*(natural/2.0);
            Console.WriteLine(sum);
        }
        static void SumOfAllEvenNumbers()
        {
            int sum = 0;
            int number = Convert.ToInt32(GiveNumber("+", "Give a number, i'll tell you the sum of all even numbers until that number"));
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all even number until {number} is {sum}");
        }
        static void SumOfAllUnevenNumbers()
        {
            int sum = 0;
            int number = Convert.ToInt32(GiveNumber("+", "Give a number, i'll tell you the sum of all uneven numbers until that number"));
            for (int i = 1; i <= number; i++)
            {
                if (!(i % 2 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all uneven number until {number} is {sum}");
        }
        static void HowManyDigits()
        {
            double number = GiveNumber("r", "Type a number of which you want me to count the digits");
            string numberString = Convert.ToString(number);
            var charsToRemove = new string[] {",", "."};
            foreach (string c in charsToRemove)
            {
                numberString = numberString.Replace(c, string.Empty);
            }
            Console.WriteLine($"The number you typed has {numberString.Length} digits.");
        }
        
    }
}
