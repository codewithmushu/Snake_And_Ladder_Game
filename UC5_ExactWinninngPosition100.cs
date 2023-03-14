using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC5_ExactWinninngPosition100
    {
        public static void Playergetsexactnumtoadd100(int PlayerPosition, int[] snakes, int[] Ladders)
        {
            //roll the die and move the player until they reach position 100
            while (PlayerPosition != 100)
            {
                Random random = new Random();
                int rolls = random.Next(1,7);
                Console.WriteLine("You rolled {0} " ,rolls);

                //Check for snakes and ladders 
                if (Array.IndexOf(snakes, PlayerPosition) >= 0 )
                {
                    PlayerPosition -= rolls;
                    if (PlayerPosition < 0)
                    {
                        PlayerPosition = 0;
                    }
                    Console.WriteLine("Oh no! You landed on a snake and slid down to position {0}", PlayerPosition);
                }
                else if (Array.IndexOf(Ladders, PlayerPosition) >= 0)
                {
                    PlayerPosition += rolls;
                    Console.WriteLine("Wow! You landed on a ladder and climbed up to position {0}", PlayerPosition);
                }
                else
                {
                    int option = random.Next(3);
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("No play! You stay in the same position {0}", PlayerPosition);
                            break;
                        case 1:
                            if (PlayerPosition + rolls <= 100)
                            {
                                PlayerPosition += rolls;
                                Console.WriteLine("Ladder! You move ahead by {0} positions to {1}", rolls, PlayerPosition);
                            }
                            else
                            {
                                Console.WriteLine("Oops! You need to roll a {0} to reach 100. You stay in the same position {1} ", 100 - PlayerPosition, PlayerPosition);
                            }
                            break;
                        case 2:
                            PlayerPosition -= rolls;
                            if ( PlayerPosition < 0)
                            {
                                PlayerPosition = 0;
                            }
                            Console.WriteLine("Snake! You moved behind {0} position to {1}", rolls, PlayerPosition);
                            break;  
                    }
                }
            }
            Console.WriteLine("Congratulations! you won.");
        }
    }
}
