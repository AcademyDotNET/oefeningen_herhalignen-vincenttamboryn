using System;

namespace BeerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            while (i > 2)
            {
                Console.WriteLine($"{i} bottles of beer on the wall, {i} bottles of beer.");
                Console.WriteLine($"Take one down and pass it around, {i - 1} bottles of beer on the wall.");
                Console.WriteLine("");
                i--;
                System.Threading.Thread.Sleep(10);
            }
            Console.WriteLine("2 bottles of beer on the wall, 2 bottles of beer.");
            Console.WriteLine("Take one down and pass it around, 1 bottle of beer on the wall.");
            Console.WriteLine("");

            Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer.");
            Console.WriteLine("Take one down and pass it around, no more bottles of beer on the wall.");
            Console.WriteLine("");

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
            Console.WriteLine("");
        }
    }
}
