using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number13
{
    class SecondPlayer : Player 
    {
        private int randomInt;

        public SecondPlayer() :base()
        { }
        override public int generateRoshambo()
        {
            Random rnd = new Random();
            return rnd.Next(0,2);

            


        }
    }
}