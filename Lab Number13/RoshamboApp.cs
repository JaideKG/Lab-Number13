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
            int ResultInt;
            int WinCount = 0, LossCount = 0, DrawCount = 0;


            Console.WriteLine("Welcome to the game of Rock, Paper, Scissors!");

            Console.WriteLine("Enter your name:");
            string playerName = Console.ReadLine();


            bool again = true;
            while (again)
                
            {

                             
                Console.Write("Would you like to play against Pat or Max (P/M)?:");
                string Opponent = Console.ReadLine();

                FourthPlayer playerfour = new FourthPlayer();
                playerfour.name = playerName;


                if (Opponent == "P")
                {
                    SecondPlayer nextplayer = new SecondPlayer();
                    nextplayer.name = "Pat";
                    int Choice = nextplayer.generateRoshambo();
                    int Select = playerfour.generateRoshambo();

                    Console.WriteLine($"You picked {(Roshambo)Select}");
                    Console.WriteLine($"Pat picked {(Roshambo)Choice}");
                    ResultInt = Validator.Referee(Select, Choice);

                    if (ResultInt == 4)
                    {
                        DrawCount++;
                    }
                    else if (ResultInt == 5)
                    {
                        LossCount++;
                    }
                    else if (ResultInt == 6)
                    {
                        WinCount++;
                    }
                    else
                    {
                        Console.WriteLine("Unexpected error has been encountered. Please contact your administration.");
                    }



                }
                else if (Opponent == "M")
                {
                    ThirdPlayer nextplayer = new ThirdPlayer();
                    nextplayer.name = "Max";
                    int Choice = nextplayer.generateRoshambo();
                    int Select = playerfour.generateRoshambo();

                    Console.WriteLine($"You picked {(Roshambo)Select}");
                    Console.WriteLine($"Max picked {(Roshambo)Choice}");

                    ResultInt = Validator.Referee(Select, Choice);

                    if (ResultInt == 4)
                    {
                        DrawCount++;
                    }
                    else if (ResultInt == 5)
                    {
                        LossCount++;
                    }
                    else if (ResultInt == 6)
                    {
                        WinCount++;
                    }
                    else
                    {
                        Console.WriteLine("Unexpected error has been encountered. Please contact your administration.");
                    }
                }

                Console.WriteLine($"Losses {LossCount}, Draws {DrawCount}, Wins {WinCount}");

                Console.WriteLine("Play again? (Y/N)");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "n")
                {
                    Console.WriteLine("Thanks for playing! Goodbye.");
                    again = false;
                }


            }


            //ThirdPlayer playerthree = new ThirdPlayer();
            //playerthree.name = "Max";
            //int Option = playerthree.generateRoshambo();





        }
    }
}
