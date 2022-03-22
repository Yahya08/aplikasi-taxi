using System;

namespace Taxi
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Taxi taxi = new();
            taxi.DriverName = "Yahya";
            taxi.OnDuty = true;
            taxi.NumPassenger = 3;
            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }
}