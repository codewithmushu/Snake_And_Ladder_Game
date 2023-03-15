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

            //Define the snakes and ladders as arrays.
            int[] snakes = { 46, 48, 52, 59, 64, 68, 69, 83, 89, 93, 98 };
            int[] Ladders = { 8, 19, 21, 28, 38, 43, 50, 54, 61, 62, 66 };

            //Define the player position
            // int PlayerPosition = 0;
            // int roll = 0;




            // UC1_SinglePlayer.StartPosition0(PlayerPosition , snakes,Ladders);
            // UC2_PlayerRollsTheDie.Random1To6(PlayerPosition ,snakes, Ladders);
            // UC3_NoPlay.NoPlay_Ladder_Snake(PlayerPosition, snakes, Ladders);
            // UC4_RepeatTillWinning.PlayerRestart(PlayerPosition,snakes,Ladders);
            // UC5_ExactWinninngPosition100.Playergetsexactnumtoadd100(PlayerPosition,snakes,Ladders);
            //UC6_NoOfTimeDicePlayed.DisplayNoOfTimeDicePlayed(PlayerPosition, snakes, Ladders, roll);
            UC7_TwoPlayers.DisplayWhoWon(snakes,Ladders);
        }
    }
}
