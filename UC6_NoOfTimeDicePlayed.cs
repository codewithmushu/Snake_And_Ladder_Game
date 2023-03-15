using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC6_NoOfTimeDicePlayed
    {
        public static void DisplayNoOfTimeDicePlayed(int PlayerPosition, int[] snakes, int[] Ladders,int roll)
        {
            //roll the die and move the player until they reach position 100
            while (PlayerPosition != 100)
            {
                Random random = new Random();
                int rolls = random.Next(1, 7);
                Console.WriteLine("You rolled {0} ", rolls);

                //increment the number of rolls
                roll++;

                //Calculate the new player position after the roll
                int newposition = PlayerPosition + rolls;

                //Check if the new position is above 100
                if (newposition > 100)
                {
                    newposition = PlayerPosition;
                }
                Console.WriteLine("You rolled {0} and moved from position {1} to position {2}", rolls, PlayerPosition, newposition);

                // Update the player position to new position
                PlayerPosition = newposition;

                //Check for snakes and ladders 
                if (Array.IndexOf(snakes, PlayerPosition) >= 0)
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
                    Console.WriteLine("No Snakes or Ladders. You stay in the same position {0}", PlayerPosition);
                }

            }
            Console.WriteLine("Congratulations! You won.");
        }
    }
}
