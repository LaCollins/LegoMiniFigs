using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigs.Composition.Torsos
{
    abstract class TorsoBase // can't be instantiated - inheretence only
    {
        public abstract bool ChiseledAbs { get; set; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        public abstract void Flex(); //Method has to exist but can be different

        public virtual void Breathe() // Has overrideable base function
        {
            Console.WriteLine("Inhale, exhale...");
        }

    }
}
