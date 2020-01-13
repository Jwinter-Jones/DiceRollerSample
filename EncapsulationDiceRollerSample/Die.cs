using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDiceRollerSample
{
    /// <summary>
    /// Represents a single 6-sided die
    /// </summary>
    class Die
    {
        // Static members get shared across all instances of this class
        private static Random rand;

        /// <summary>
        /// Runs once before any Die objects are created
        /// and initializes Random object once
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current value of the die 1 - 6
        /// </summary>
        public byte FaceValue {
            get { return faceValue; } 
            private set
            {
                if(value < 1 || value > 6)
                {
                    throw new ArgumentException("Invalid face value");
                }
                faceValue = value;
            }
        }

        /// <summary>
        /// Die that are held are not rolled
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Generates a new random face value. Sets the face value
        /// and returns the generated value
        /// </summary>
        public byte Roll()
        {
            // If current die is held, return the current value
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1;
            const byte MaxValue = 6;
            // Offset it for the exclusive range of Random.Next()
            const byte Offset = 1;
            byte newValue = (byte)rand.Next(MinValue, MaxValue + Offset);

            FaceValue = newValue;
            return newValue;
        }
    }
}
