using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game Objects is made
            Game newGame = new Game();
            //Outputs the value of the sum of the three die rolls
            Console.WriteLine("The Sum of the 3 Dice Rolls = ", newGame.DieRollAndSum());
            //Testing object is created
            Testing newTest = new Testing();
            //Firstly testing the Die class output
            newTest.TestingDieValue();
            //Then tests the Game class output
            newTest.TestingGameValues();
        }
    }
}
