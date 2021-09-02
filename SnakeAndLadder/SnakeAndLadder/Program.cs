using System;

namespace SnakeAndLadder
{
    class Program
    {

        static int Roll_Dice()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }
        static void Main(string[] args)
        {
            int Start = 0;
            int Finish = 100;

            Console.WriteLine("Welcome To Snake and Ladder game.");
            // player initial position
            int player_position = 0;
            Console.WriteLine("Player current position is " + player_position);

            // player rolls the dice and gets the value
            int player_Roll_Dice = Roll_Dice();
            Console.WriteLine("Player Dice value is " + player_Roll_Dice);
        }
    }
}
