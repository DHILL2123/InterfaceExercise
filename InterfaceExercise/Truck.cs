using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        string designedToCarryLoads         { get ; set; }
        int highTowingCapacity              { get ; set; }
        public string allHaveWheels           { get ; set; }
        public bool allNeedFuel             { get ; set; }
        public int oneWindShieldAtLeast     { get ; set; }
        public string willBreakDown         { get ; set; }
        public string logo                  { get ; set; }
        public string catchPhrase           { get ; set; }

        public Truck()
        {
        }
    }
}
























