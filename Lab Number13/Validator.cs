using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number13
{
    class Validator
    {
        public static Roshambo ValidChoice()
        {
            //two ways to access enum fitst by name
            //Roshambo.Rock
            //second by index
            //(Roshambo)0  change this number for diff values

            while (true)
            {


                Console.WriteLine("Please select either Rock, Paper, or Scissors.");
                string input = Console.ReadLine();


                if (input != "Rock" && input != "Paper" && input != "Scissors")
                {
                    Console.WriteLine("Your choice was invalid. Please try again.");
                }
                else if (input == "Rock")
                {
                    return Roshambo.Rock;
                }
                else if (input == "Paper")
                {
                    return Roshambo.Paper;
                }
                else if (input == "Scissors")
                {
                    return Roshambo.Scissors;
                }




            }


        }
        //0 = Rock, 1 = Paper, 2 = Scissors
        //4 = Draw, 5 = Loss, 6 = Win
        public static int Referee(int User, int Computer)
        {
            if (User == 0 && Computer == 0)
            {
                Console.WriteLine("Draw!");
                return 4;
            }
            else if (User == 0 && Computer == 1)
            {
                Console.WriteLine("Loss!");
                return 5;
            }
            else if (User == 0 && Computer == 2)
            {
                Console.WriteLine("Win!");
                return 6;
            }
            else if (User == 1 && Computer == 0)
            {
                Console.WriteLine("Win!");
                return 6;
            }
            else if (User == 1 && Computer == 1)
            {
                Console.WriteLine("Draw!");
                return 4;
            }
            else if (User == 1 && Computer == 2)
            {
                Console.WriteLine("Loss!");
                return 5;
            }
            else if (User == 2 && Computer == 0)
            {
                Console.WriteLine("Loss!");
                return 5;
            }
            else if (User == 2 && Computer == 1)
            {
                Console.WriteLine("Win!");
                return 6;
            }
            else if (User == 2 && Computer == 2)
            {
                Console.WriteLine("Draw!");
                return 4;
            }
            else
            {
                return 0;
            }

        }
    } 
}
  
        
            
