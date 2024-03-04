using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die

    {
        int dieValue;
       
        //Property
        public int RollValue => Roll();

        //Method

        private int Roll() 
        { 
            Random rnd = new Random();
            dieValue = rnd.Next(1, 7);
            return dieValue;
        }
    }
}
