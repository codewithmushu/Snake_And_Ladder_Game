using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC7_TwoPlayers
    {
        public static void DisplayWhoWon(int[] snakes, int[] Ladders)
        {
            //Define the player positions and flags
            int Player1Position = 0;
            int Player2Position = 0;


            //Roll Die and move the player until one of them reaches 100
            int CurrentPlayer = 1;
            while (Player1Position < 100 && Player2Position < 100 )
            {
                Random random = new Random();
                int rolls = random.Next(1, 7);
                Console.WriteLine("Player {0} rolled a {1}",CurrentPlayer,rolls);

              

                //Check for snakes and ladders
                int PlayerPosition = CurrentPlayer == 1 ? Player1Position : Player2Position;
                if (Array.IndexOf(snakes, PlayerPosition) >= 0)
                {
                    PlayerPosition -= 10;
                    if (PlayerPosition < 0)
                    {
                        PlayerPosition = 0;
                    }
                    Console.WriteLine("oh no! Player {0} landed on a snake and slid down to position {1}", CurrentPlayer,PlayerPosition);
                }
                else if (Array.IndexOf(Ladders, PlayerPosition) >= 0)
                {
                    Console.WriteLine("Wow! Player {0} landed on a ladder and climb up and get chance to play again! ", CurrentPlayer);
                }
                else
                {
                    PlayerPosition += rolls;
                    if (PlayerPosition > 100)
                    {
                        PlayerPosition -= rolls ;
                    }
                    Console.WriteLine("Player {0} moved ahead by {1} positions to {2}",CurrentPlayer,rolls,PlayerPosition);
                }

                //Update the Player Position and turn
                if (CurrentPlayer == 1)
                {
                    Player1Position = PlayerPosition;
                    CurrentPlayer = 2;
                }
                else
                {
                    Player2Position = PlayerPosition;
                    CurrentPlayer = 1;
                }
            }

            //Report which player won the game.
            if (Player1Position >= 100)
            {
                Console.WriteLine("Player 1 won the game!");
            }
            else
            {
                Console.WriteLine("Player 2 won the game!");
            }

            
        }

    }
}
