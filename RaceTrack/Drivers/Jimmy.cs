using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Jimmy:Driver
    {
        public Jimmy(RaceCar car) : base(car)
        {
            Name = "Jimmy";
            SkillLevel = 9;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}