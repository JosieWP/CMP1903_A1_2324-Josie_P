using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Testing
    {                           
        //Method
        //Creating a method to check the Die class output
        public void TestingDieValue()
        {
            //Creating a list of expected outputs
            int[] checkDie = { 1, 2, 3, 4, 5, 6 };
            //Creating a Die Object to be tested
            Die testDie = new Die();

            //Goes through each of the expected outputs in my list and compares it to the Die class output
            foreach(int i in checkDie)
            {
                Debug.Assert(i == testDie.RollValue, "The die is not between 1-6");
                //Prints a message explaining the issue if the condition parameter of the Assert method comes up false
            }
            
        }
        //Creating a method to test the Game class
        public void TestingGameValues()
        {
            //Creating a list the the Game class' expected outputs
            int[] checkGame = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            //Creates a Game object for testing
            Game testGame = new Game();
            //Goes through the expected Game output list to the actual Game class output
            foreach(int i in checkGame)
            {
                Debug.Assert(i == testGame.rollSum, "The sum of the 3 die rolls is not between 3-18");
                //Prints message explaining issue if the condition is false
            }

        }
    }
}
