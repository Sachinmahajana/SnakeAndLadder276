namespace SnakeAndLadder276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            //UC1-Playerposition
            int PlayerPosition = 0;
            int start = 0;
            Console.WriteLine("Start Position:" + start);

            //UC2-Diceroll
            Random random = new Random();
            int roll = random.Next(0, 7);
            start = start + roll;
            Console.WriteLine("You Got : " + roll);
            Console.WriteLine("Player position at : " + start);
            //UC3-Checkplayer Position
            int Option = random.Next(0, 3);
            Console.ReadLine();
            if (Option == 0)
            {
                PlayerPosition = PlayerPosition - roll;
                Console.WriteLine("snake " + PlayerPosition);
            }
            else if (Option == 1)
            {
                PlayerPosition = PlayerPosition + roll;
                Console.WriteLine("ladder " + PlayerPosition);
            }
            else
            {
                Console.WriteLine("no play " + PlayerPosition);
            }
        }
    }
}