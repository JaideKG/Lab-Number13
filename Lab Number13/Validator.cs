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


                Console.WriteLine("Please select either Rock, Papepr, or Scissors.");
                string input = Console.ReadLine();

               
                if (input != "Rock" && input != "Paper" && input != "Scissors")
                {
                    continue;
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
    }
}
