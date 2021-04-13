using System;

namespace WriteNumbers
{
    class Program
    {
        enum Magnitude { thousand = 1, million, billion, trillion, quadrillsion, quintillion }
        static void Main(string[] args)
        {
            for (long i = 0; i < 2500; i++)
            {
                WriteNumberInFullTest(i);
            }
            WriteNumberInFull();
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

        static void WriteNumberInFullHundreds()
        {
            int numberToWrite = Convert.ToInt32(GiveNumber("int", "type a number you want me to write out"));
            string DigitsString = Convert.ToString(numberToWrite);
            int HowManyDigits = DigitsString.Length;
            string numberText = "";
            int j = 0;
            for (int i = HowManyDigits - 1; i >= 0; i--)
            {

                int nextDigit = Convert.ToInt32(Convert.ToString(DigitsString[j]));

                if (i == 2)
                {
                    numberText += WriteNumberUnits(nextDigit) + "hundred ";
                }
                else if (i == 1)
                {
                    if (nextDigit == 1)
                    {
                        numberText += WriteNumbersElevenUntilNineteen(Convert.ToInt32(Convert.ToString(DigitsString[j + 1]))) + " ";
                        i--;
                    }
                    else
                    {
                        numberText += WriteNumberTens(nextDigit) + " ";
                    }
                }
                else if (i == 0)
                {
                    numberText += WriteNumberUnits(nextDigit) + " ";
                }
                j++;
            }
            Console.WriteLine(numberText);
        }
        static string WriteNumberUnits(long number)
        {
            string text = "";
            switch (number)
            {
                case 1:
                    text = "one";
                    return text;
                case 2:
                    text = "two";
                    return text;
                case 3:
                    text = "three";
                    return text;
                case 4:
                    text = "four";
                    return text;
                case 5:
                    text = "five";
                    return text;
                case 6:
                    text = "six";
                    return text;
                case 7:
                    text = "seven";
                    return text;
                case 8:
                    text = "eight";
                    return text;
                case 9:
                    text = "nine";
                    return text;
                default:
                    return text;
            }
        }
        static string WriteNumberTens(long number)
        {
            string text = "";
            switch (number)
            {
                case 1:
                    text = "ten";
                    return text;
                case 2:
                    text = "twenty";
                    return text;
                case 3:
                    text = "thirty";
                    return text;
                case 4:
                    text = "fourty";
                    return text;
                case 5:
                    text = "fifty";
                    return text;
                case 6:
                    text = "sixty";
                    return text;
                case 7:
                    text = "seventy";
                    return text;
                case 8:
                    text = "eighty";
                    return text;
                case 9:
                    text = "ninety";
                    return text;
                default:
                    return text;
            }
        }
        static string WriteNumbersElevenUntilNineteen(long number)
        {
            string text = "";
            switch (number)
            {
                case 1:
                    text = "eleven";
                    return text;
                case 2:
                    text = "twelve";
                    return text;
                case 3:
                    text = "thirteen";
                    return text;
                case 4:
                    text = "fourteen";
                    return text;
                case 5:
                    text = "fiveteen";
                    return text;
                case 6:
                    text = "sixteen";
                    return text;
                case 7:
                    text = "seventeen";
                    return text;
                case 8:
                    text = "eightteen";
                    return text;
                case 9:
                    text = "nineteen";
                    return text;
                default:
                    text = "ten";
                    return text;
            }
        }
        static string WriteNumberInFullHundredsReturn(long numberToWrite)
        {
            string DigitsString = Convert.ToString(numberToWrite);
            int HowManyDigits = DigitsString.Length;
            string numberText = "";
            int j = 0;
            for (int i = HowManyDigits - 1; i >= 0; i--)
            {

                long nextDigit = Convert.ToInt32(Convert.ToString(DigitsString[j]));

                if (i == 2)
                {
                    if (DigitsString[j + 1] == '0' && DigitsString[j + 2] == '0')
                    {
                        numberText += WriteNumberUnits(nextDigit) + " hundred ";
                    }
                    else
                    {
                        numberText += WriteNumberUnits(nextDigit) + " hundred and ";
                    }
                }
                else if (i == 1)
                {
                    if (nextDigit == 1)
                    {
                        numberText += WriteNumbersElevenUntilNineteen(Convert.ToInt32(Convert.ToString(DigitsString[j + 1]))) + " ";
                        i--;
                    }
                    else
                    {
                        numberText += WriteNumberTens(nextDigit) + " ";
                    }
                }
                else if (i == 0)
                {
                    numberText += WriteNumberUnits(nextDigit) + " ";
                }
                j++;
            }
            return numberText;
        }
        static void WriteNumberInFull()
        {
            long numberToWrite = Convert.ToInt64(GiveNumber("int", "type a number you want me to write out"));
            string numberInString = Convert.ToString(numberToWrite);
            int setsTotaal = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(numberInString.Length) / 3.0)));
            string numberWritten = "";
            int aantalEersteGetallen;
            int magnitude = setsTotaal - 1;

            if (numberInString == "0")
            {
                numberWritten = "zero";
                Console.WriteLine(numberWritten);
                return;
            }

            if (numberInString.Length > 3)
            {
                if (numberInString.Length % 3 == 0)
                {
                    aantalEersteGetallen = 3;
                }
                else
                {
                    aantalEersteGetallen = numberInString.Length % 3;
                }
            }
            else
            {
                aantalEersteGetallen = numberInString.Length;
            }

            string[] sets;
            sets = new string[setsTotaal];


            for (int setCounter = 0; setCounter < setsTotaal; setCounter++)
            {
                if (setCounter == 0)
                {
                    for (int i = 0; i < aantalEersteGetallen; i++)
                    {
                        sets[0] = sets[0] + Convert.ToString(numberInString[i]);
                    }
                }
                else if (setCounter == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sets[setCounter] = sets[setCounter] + Convert.ToString(numberInString[aantalEersteGetallen + i]);
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sets[setCounter] = sets[setCounter] + Convert.ToString(numberInString[aantalEersteGetallen + i + 3 * (setCounter - 1)]);
                    }
                }
            }

            foreach (string c in sets)
            {
                if (c == "000")
                {
                    magnitude--;
                }
                else if (magnitude != 0)
                {
                    numberWritten += WriteNumberInFullHundredsReturn(Convert.ToInt32(c)) + Convert.ToString((Magnitude)(magnitude)) + " ";
                    magnitude--;
                }
                else
                {
                    numberWritten += WriteNumberInFullHundredsReturn(Convert.ToInt32(c));
                }

            }
            Console.WriteLine(numberWritten);
        }
        static void WriteNumberInFullTest(long numberToWrite)
        {
            string numberInString = Convert.ToString(numberToWrite);
            int setsTotaal = Convert.ToInt32(Math.Ceiling((Convert.ToDouble(numberInString.Length) / 3.0)));
            string numberWritten = "";
            int aantalEersteGetallen;
            int magnitude = setsTotaal - 1;

            if (numberInString == "0")
            {
                numberWritten = "zero";
                Console.WriteLine(numberWritten);
                return;
            }

            if (numberInString.Length > 3)
            {
                if (numberInString.Length % 3 == 0)
                {
                    aantalEersteGetallen = 3;
                }
                else
                {
                    aantalEersteGetallen = numberInString.Length % 3;
                }
            }
            else
            {
                aantalEersteGetallen = numberInString.Length;
            }

            string[] sets;
            sets = new string[setsTotaal];


            for (int setCounter = 0; setCounter < setsTotaal; setCounter++)
            {
                if (setCounter == 0)
                {
                    for (int i = 0; i < aantalEersteGetallen; i++)
                    {
                        sets[0] = sets[0] + Convert.ToString(numberInString[i]);
                    }
                }
                else if (setCounter == 1)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sets[setCounter] = sets[setCounter] + Convert.ToString(numberInString[aantalEersteGetallen + i]);
                    }
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sets[setCounter] = sets[setCounter] + Convert.ToString(numberInString[aantalEersteGetallen + i + 3 * (setCounter - 1)]);
                    }
                }
            }

            foreach (string c in sets)
            {
                if (c == "000")
                {
                    magnitude--;
                }
                else if (magnitude != 0)
                {
                    numberWritten += WriteNumberInFullHundredsReturn(Convert.ToInt32(c)) + Convert.ToString((Magnitude)(magnitude)) + " ";
                    magnitude--;
                }
                else
                {
                    numberWritten += WriteNumberInFullHundredsReturn(Convert.ToInt32(c));
                }

            }
            Console.WriteLine(numberWritten);
        }
    }
}
