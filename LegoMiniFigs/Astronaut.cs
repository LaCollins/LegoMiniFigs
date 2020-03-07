using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigs
{

    class Astronaut
    {
        public Location Location { get; set; }
        public bool SuitedUp => Name == "Space Force Bill"; // expression bodied property (always read only)
        public string Name { get; } // read only
        public string Job { get; private set; }  // Only set within class unless set in instantiation "Public property with a private setter"
        public int OxygenLevel { get; set; }

        public Astronaut(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
        }

    }
}
