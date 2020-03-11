using LegoMiniFigs.Composition.Heads;
using LegoMiniFigs.Composition.Legs;
using LegoMiniFigs.Composition.Torsos;
using System;

namespace LegoMiniFigs
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ZoeHead()
            {
                FacialExpression = "smiling",
                Color = LegoColor.Orange,
                Helmeted = true
            };

            var atorso = new AstronautTorso()
            {
                Shirted = true,
                ChiseledAbs = false,
                HandType = HandType.BabyHands,
                NumberOfHands = 3
            };

            var dtorso = new DadBodTorso()
            {
                Shirted = true,
                ChiseledAbs = false,
                HandType = HandType.BabyHands
            };

            var legs = new AstronautLegs()
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            atorso.Breathe();
            dtorso.Breathe();


            var astronaut = new Astronaut("Space Force Bill", "Janitor", head, dtorso, legs);
            var astronaut2 = new Astronaut("Space Force Jill", "Space Welder", head, atorso, legs);


            astronaut.DoYourJob();
            astronaut2.Promote();
            astronaut2.DoYourJob();


            var casper = new Ghost("Capser", DateTime.Today)
            { // object initializer
                Friendly = true,
                IsVisible = true
            };

            casper.Spook(); // does nothing because of return and Haunt not being set.
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatso = new Ghost("Fatso", new DateTime(1924, 12, 1))
            {
                Friendly = false
            };            
            
            fatso.Spook(); // does nothing because of return and Haunt not being set.
            fatso.Haunt("Whipstaff Manor");
            fatso.Spook();



            Console.ReadKey();
        }
    }
}
