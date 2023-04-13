using System.Xml.Linq;

namespace SnakeAndLadder276
{
    internal class Program
    {
        public const int SNAKE = 2;
        public const int LADDER = 1;
        public const int NOPLYER = 0;
        public const int TotalDiceCount = 0;

        static void Main(string[] args)
        {
            {
                int PlayerPosition = 0;
                int start = 0;
                Console.WriteLine("Start Position:" + start);
                while (PlayerPosition < 100)
                {
                    Random random = new Random();
                    int roll = random.Next(0, 7);
                    Console.WriteLine("After Rolling a dice" + roll);
                    ++roll;
                    int Option = random.Next(0, 3);
                    Console.WriteLine("Option is " + Option);
                    Console.ReadLine();
                    if (Option == SNAKE)
                    {
                        PlayerPosition = PlayerPosition - roll;
                        Console.WriteLine("snake " + PlayerPosition);
                    }
                    else if (Option == LADDER && (PlayerPosition + roll) < 100)
                    {
                        PlayerPosition = PlayerPosition + roll;
                        Console.WriteLine("ladder " + PlayerPosition);

                    }
                    else
                    {
                        Console.WriteLine("no play " + PlayerPosition);
                    }
                    if (PlayerPosition <= 100)
                    {
                        PlayerPosition = PlayerPosition + roll;
                    }
                    if (PlayerPosition <= 0)
                    {
                        PlayerPosition = PlayerPosition - roll;
                        Console.WriteLine("Player Position" + PlayerPosition);
                        Console.WriteLine("Dice Count " + roll);
                    }
                    else if (PlayerPosition == 100)
                    {
                        Console.WriteLine("player has won");
                        Console.ReadLine();
                        break; 
                    }
                    int TotalDiceCountroll = +roll;            
                    Console.WriteLine("Total Dice Count Played to win the game:" + TotalDiceCount);

                    Console.ReadLine();
                }
            }
        }
    }
}