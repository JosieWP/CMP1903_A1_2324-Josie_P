﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public int rollSum;
       
        //Methods
        /// <summary>
        /// creates 3 objects from die class, then 'rolls' them
        /// </summary>
        /// <returns>integers equaling the sum of the 3 rolled die objects</returns>
        public int DieRollAndSum()
        {
            //Creates three Die Objects
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();
            //Variable 'rollSum' holds value of the the die objects summed after being rolled
            rollSum = dice1.RollValue + dice2.RollValue + dice3.RollValue;
            return rollSum;

        }
        
    }
}
