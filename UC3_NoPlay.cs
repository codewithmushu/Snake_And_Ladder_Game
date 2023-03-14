using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class UC3_NoPlay
    {
        public static void NoPlay_Ladder_Snake(int PlayerPosition,int[] snakes, int[] Ladders)
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
                    Console.WriteLine("Oh no ! you landed on a snake and slide down to position {1}" ,rolls, PlayerPosition);

                }
                else if (Array.IndexOf(Ladders,PlayerPosition) >= 0 )
                {
                    PlayerPosition += rolls;
                    Console.WriteLine("Wow! you landed on a ladder and moved ahead to position {1} ",rolls, PlayerPosition);

                }
                else
                {
                    int position = random.Next(3);
                    switch (position)
                    {
                        case 0: 
                            Console.WriteLine("No play! you stay in the same position {0}", PlayerPosition);
                            break;
                        case 1:
                            PlayerPosition += rolls;
                            Console.WriteLine("Ladder! you move ahead by {0} position to {1} ",rolls, PlayerPosition);
                            break;
                        case 2: 
                            PlayerPosition -= rolls;
                            Console.WriteLine("Snake! you move behind {0} position to {1}",rolls, PlayerPosition);
                            break;
                    }

                }

            }
            Console.WriteLine("congratulations! you won.");
        }
    }
}
