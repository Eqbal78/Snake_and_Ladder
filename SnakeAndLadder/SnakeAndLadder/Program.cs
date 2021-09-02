using System;

namespace SnakeAndLadder
{
    class Program
    {
        static Random r = new Random();
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        const int Start = 0;
        const int Finish = 100;

        static int Roll_Dice()
        {
            return r.Next(1, 7);
        }

        static int Player_Move_Option(int player_Roll_Dice)
        {
            // Player Option is gentrated..
            int check_Player_Option = r.Next(0, 3);
            int player_Move = 0;
            switch (check_Player_Option)
            {
                case LADDER:
                    player_Move = player_Roll_Dice;
                    break;
                case SNAKE:
                    player_Move = -player_Roll_Dice;
                    break;
                default:
                    break;
            }
            return player_Move;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Snake and Ladder game.");
            // player initial position
            int player_position = 0, player_Next_Position = 0;
            Console.WriteLine("Player current position is " + player_position);

            while (player_position < Finish)
            {


                int player_Roll_Dice = Roll_Dice();
                
                // The Player then checks for a Option. They are No Play,Ladder or Snake.
                int player_Move = Player_Move_Option(player_Roll_Dice);
                int position = player_position + player_Move;
                
                if (position > Finish)
                {
                    player_Next_Position = player_position;

                }
                else
                {
                    player_Next_Position = player_position + player_Move;

                }
                if (player_Next_Position < Start)
                {
                    player_position = Start;
                }
                else
                {
                    player_position = player_Next_Position;
                }


            }
            Console.WriteLine("Player current position After rolling the Dice is " + player_position);
        }
    }
}
