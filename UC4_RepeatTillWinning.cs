using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC4_RepeatTillWinning
    {
        // Repeat till the Player reaches the winning position 100. - Note In case the player position moves below 0, then the player restarts from 0

        public static void PlayerRestart(int PlayerPosition,int[] snakes, int[] Ladders)
        {
            //Roll the die and move the player until player reaches position 100.
            while (PlayerPosition < 100)
            {
                Random random = new Random();
                int rolls = random.Next(1, 7);
                PlayerPosition += rolls;
                Console.WriteLine("You rolled a {0} and moved to position {1} ", rolls, PlayerPosition);

                //check for snakes and ladders.
                if (Array.IndexOf(snakes,PlayerPosition) >= 0)
                {
                    PlayerPosition = rolls;
                   if (PlayerPosition < 0)
                    {
                        PlayerPosition = 0;
                    }
                    Console.WriteLine("oh no! You landed on a snake and slide down to position {0} ", PlayerPosition);
                }
                else if (Array.IndexOf(Ladders, PlayerPosition) >= 0)
                {
                    PlayerPosition += rolls;
                    Console.WriteLine("Wow! you landed on a ladder and moved ahead to position {1} ", rolls, PlayerPosition);
                }
                else
                {
                    int position = random.Next(0,3);
                    switch (position)
                    {
                        case 0:
                            Console.WriteLine("No play! You stay in the same position {0} ", PlayerPosition);
                            break;
                        case 1:
                            PlayerPosition += rolls;
                            if (PlayerPosition > 100)
                            {
                                PlayerPosition -= rolls;
                            }
                            Console.WriteLine("Ladder! You moved ahead by {0} and positions to {1} " ,rolls, PlayerPosition);
                            break;
                        case 2:
                            PlayerPosition -= rolls;
                            if (PlayerPosition < 0)
                            {
                                PlayerPosition = 0;
                            }
                            Console.WriteLine("Snake! You moved behind by {0} and positions to {1} ", rolls , PlayerPosition);
                            break;  
                    }
                }
            }
            Console.WriteLine("Congratulations! you won.");
        } 


    }
}
