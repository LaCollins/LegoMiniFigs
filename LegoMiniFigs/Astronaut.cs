using LegoMiniFigs.Composition.Heads;
using LegoMiniFigs.Composition.Legs;
using LegoMiniFigs.Composition.Torsos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigs
{

    class Astronaut
    {
        private string v1;
        private string v2;
        private ZoeHead head;
        private object legs;

        public Location Location { get; set; }
        public bool SuitedUp => Name == "Space Force Bill"; // expression bodied property (always read only)
        public string Name { get; } // read only
        public string Job { get; private set; }  // Only set within class unless set in instantiation "Public property with a private setter"
        public int OxygenLevel { get; set; }

        public TorsoBase Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public ZoeHead Head { get; set; }


        public Astronaut(string name, string job,
                         ZoeHead head, TorsoBase torso, AstronautLegs legs)
        {
            Name = name;
            Job = job;
            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public Astronaut(string v1, string v2, ZoeHead head, TorsoBase torso, object legs)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.head = head;
            Torso = torso;
            this.legs = legs;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob()
        {
            Console.WriteLine($"{Name} is doing all their {Job} duties...");
            Legs.Walk(15);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(10);
        }

    }
}
