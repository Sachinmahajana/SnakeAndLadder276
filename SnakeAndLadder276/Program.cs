﻿namespace SnakeAndLadder276
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
<<<<<<< HEAD
            while (PlayerPosition < 100)
=======

            //UC2-Diceroll
            Random random = new Random();
            int roll = random.Next(0, 7);
            Console.WriteLine("After Rolling a dice" + roll);
            //UC3-Checkplayer Position
            int Option = random.Next(0, 3);
            Console.ReadLine();
            if (Option == 0)
>>>>>>> UC3-Checkplayerposition
            {
                //UC2-Diceroll
                Random random = new Random();
                int roll = random.Next(0, 7);
                start = start + roll;
                Console.WriteLine("You Got : " + roll);
                Console.WriteLine("Player position at : " + start);
                Console.WriteLine("After Rolling a dice" + roll);
                //UC3-Checkplayer Position
                int Option = random.Next(0, 3);
                Console.WriteLine("Option is " + Option);
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
                if(PlayerPosition<= 100)
                {
                    PlayerPosition = PlayerPosition + roll;
                }
                else if (PlayerPosition < 0)
                {
                    PlayerPosition = PlayerPosition - roll;
                }
                else if(PlayerPosition == 100)
                {
                    Console.WriteLine("Player has won");
                }
            }
        }
    }
}