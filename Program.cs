using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game World");

             int[] snakes = { 46, 48, 52, 59, 64, 68, 69, 83, 89, 93, 98 };
             int[] Ladders = { 8, 19, 21, 28, 38, 43, 50, 54, 61, 62, 66 };

            //int[] snakes = { 17 , 54, 62, 98 };
            //int[] Ladders = { 3, 24, 42, 72 };
 
            //Define the player position
            int PlayerPosition = 0;


            // UC1_SinglePlayer.StartPosition0();
            // UC2_PlayerRollsTheDie.Random1To6(PlayerPosition);
            UC3_NoPlay.NoPlay_Ladder_Snake(PlayerPosition, snakes, Ladders);
        }
    }
}
