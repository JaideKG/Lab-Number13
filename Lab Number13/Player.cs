using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number13
{
    enum Roshambo
    {
        Rock,//index of 0
        Paper,//index of 1
        Scissors//index of 2
    }

    abstract class Player
    {
        

        public string name { get; set; }
            
        public string response { get; set; }
        public int valueRoshambo { get; set; }
        abstract public int generateRoshambo();

        



            
        
        
    }
}
