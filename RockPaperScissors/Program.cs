using System;

namespace RockPaperScissors
{
    class Program
    {
        enum RockPaperScissors {rock = 1, paper, scissors}
        static void Main(string[] args)
        {
            Random rand = new Random();

            //points[0] = human points, points[1] = computer points
            int[] points = { 0, 0 };
            int computer;
            string humanInput = "";

            while (points[0] < 10 && points[1] < 10)
            {
                computer = rand.Next(1, 4);
                string computerChoice = Convert.ToString((RockPaperScissors)computer);

                while (humanInput != "rock" && humanInput != "paper" && humanInput != "scissors")
                {
                    Console.WriteLine("Rock, paper of scissors?");
                    humanInput = Console.ReadLine();
                    humanInput = humanInput.ToLower();
                }

                points = WhoWon(humanInput, computerChoice, points);
                Scores(points[0],points[1]);
                humanInput = "";

            }
            if (points[0] == 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Congratulations human, you won!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You lost human, the computer was superior!");
            }
        }
        static int[] WhoWon(string input1, string input2, int [] points)
        {
            if (input1 == input2)
            {
                Console.WriteLine("it's a tie! No points");
                return points;
            }
            else if (input1 == "paper")
            {
                if (input2 == "rock")
                {
                    points[0]++;
                    Console.WriteLine("You won! +1 points for you");
                    return points;
                }
                else
                {
                    points[1]++;
                    Console.WriteLine("You lost! +1 points for the computer");
                    return points;
                }
            }
            else if (input1 == "rock")
            {
                if (input2 == "scissors")
                {
                    points[0]++;
                    Console.WriteLine("You won! +1 points for you");
                    return points;
                }
                else
                {
                    points[1]++;
                    Console.WriteLine("You lost! +1 points for the computer");
                    return points;
                }
            }
            else if (input1 == "scissors")
            {
                if (input2 == "paper")
                {
                    points[0]++;
                    Console.WriteLine("You won! +1 points for you");
                    return points;
                }
                else
                {
                    points[1]++;
                    Console.WriteLine("You lost! +1 points for the computer");
                    return points;
                }
            }
            else
            {
                return points;
            }
        }
        static void Scores(int score1, int score2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You: {score1} points");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Computer: {score2} points");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
