using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number13
{
    class FourthPlayer : Player
    {
        public FourthPlayer() : base()
        { }
        override public int generateRoshambo()
        {
            return (int)Validator.ValidChoice();
            
        }

    }
}
