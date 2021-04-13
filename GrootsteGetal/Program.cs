using System;

namespace GrootsteGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int largestinstring = 0;
            do
            {
                y += x;
                Console.WriteLine("Voer gehele waarden in (32767=stop)");
                string instring = Console.ReadLine();
                x = Convert.ToInt32(instring);
                
                if ((x > largestinstring) && (x != 32767))
                {
                    largestinstring = x;
                }

            } while (x != 32767);
            Console.WriteLine($"Som is {y}, de grootst ingegeven waarde is {largestinstring}");
        }
    }
}
