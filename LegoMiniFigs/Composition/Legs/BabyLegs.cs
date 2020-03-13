using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigs.Composition.Legs
{
    class BabyLegs
    {
        public bool CanWalk { get; set; }
        public int NumberOfRolls { get; set; }
        public bool IsClumsy => true;
        public bool HasPants { get; set; }

        public void Walk(int steps)
        {
            if (CanWalk)
            {
                Console.WriteLine($"Baby legs walk around {steps} steps and then falls down.");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} baby feet.");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kick with the power of {NumberOfRolls} fat rolls!");
        }
    }
}
