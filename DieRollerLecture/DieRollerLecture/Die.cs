using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRollerLecture
{
    /// <summary>
    /// Represnets a single six sided die (1-6)
    /// </summary>
    internal class Die
    {
        private static Random _random;
        /// <summary>
        /// Creates the die and rolls it to start with
        /// a random number
        /// </summary>
        public Die()
        {
            _random = new Random();
        }
        /// <summary>
        /// The current face up value
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rools the die and sets the <see cref="FaceValue"/>
        /// to the new number. Returns the new number
        /// </summary>
        /// <returns>Returns the <see cref="FaceValue"/></returns>
        public byte Roll()
        {
            // Check if held
            if (!IsHeld)
            {
                // Generate random number
                byte newValue = (byte)_random.Next(1, 7);

                // Set to face value
                FaceValue = newValue;
            }
            // Return new number
            return FaceValue;
        }
    }
}
