using System;

namespace LegoMiniFigs
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Force Bill", "Janitor");
            var astronaut2 = new Astronaut("Space Force Jill", "Space Welder");

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
