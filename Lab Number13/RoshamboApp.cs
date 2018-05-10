using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number13
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the game of Rock, Paper, Scissors!");

            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();

            Console.Write("Would you like to play against Pat or Max (P/M)?:");
            Console.ReadLine();

            SecondPlayer nextplayer = new SecondPlayer();
            nextplayer.name = "Pat";
            int Choice = nextplayer.generateRoshambo();

            ThirdPlayer playerthree = new ThirdPlayer();
            playerthree.name = "Max";
            int Option = playerthree.generateRoshambo();

            FourthPlayer playerfour = new FourthPlayer();
            playerfour.name = playerName;
            int Select = playerfour.generateRoshambo();

            Validator.ValidChoice();

            


        }
    }
}
