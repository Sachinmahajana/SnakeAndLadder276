namespace SnakeAndLadder276
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            //UC1-Playerposition
            int start = 0;
            Console.WriteLine("Start Position:" + start);

            //UC2-Diceroll
            Random random = new Random();
            int roll = random.Next(0, 7);
            start = start + roll;
            Console.WriteLine("You Got : " + roll);
            Console.WriteLine("Player position at : " + start);
        }
    }
}