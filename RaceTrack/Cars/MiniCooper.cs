using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class MiniCooper : RaceCar
    {
        public MiniCooper() {
            Name = "engine swapped Mini Cooper";
            TopSpeed = 125;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} breaks really hard");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} stops their engine");
        }
        
    }
}