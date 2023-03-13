using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC2_PlayerRollsTheDie
    {
        public static void Random1To6(int PlayerPosition, int[] snakes  , int[] Ladders)
        {
            while (PlayerPosition < 100)
            {
                Random random = new Random();
                int rolls = random.Next(1, 7);
                //_ = random.Next(1, 7);
                PlayerPosition += rolls;
                Console.WriteLine("You rolled a {0} and moved to position {1} ", rolls, PlayerPosition);

                //Check for snakes and ladders
                if (Array.IndexOf(snakes, PlayerPosition) >= 0)
                {
                    PlayerPosition -= rolls;
                    Console.WriteLine("Oh no ! you landed on a snake and slide down to position {0}", PlayerPosition);

                }
                else if (Array.IndexOf(Ladders, PlayerPosition) >= 0)
                {
                    PlayerPosition += rolls;
                    Console.WriteLine("Wow! you landed on a ladder and moved ahead to position {0} ", PlayerPosition);

                }

            }
            
        }
    }
}
