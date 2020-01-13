using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];

            InitDice(dice);
            PrintDieFaceValues(dice);

            // Hold first 3 dice
            dice[0].IsHeld = true;
            dice[1].IsHeld = true;
            dice[2].IsHeld = true;

            Console.WriteLine("\nHolding first 3, rerolling\n");
            RollAllDice(dice);
            PrintDieFaceValues(dice);

            /*
            Die myDice = new Die();
            // FaceValue is set to private, this is not allowed
            // myDice.FaceValue = 6;
            Console.WriteLine(myDice.FaceValue);
            
            myDice.Roll();

            Console.WriteLine(myDice.FaceValue);
            */

            Console.ReadKey();
        }

        private static void RollAllDice(Die[] dice)
        {
            // Print out values
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }

        private static void PrintDieFaceValues(Die[] dice)
        {
            // Print out values
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }
        }

        /// <summary>
        /// Initializes all die in a given array
        /// Assumes array has been given a length
        /// </summary>
        /// <param name="dice"></param>
        private static void InitDice(Die[] dice)
        {
            // Create 5 dice
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
    }
}
