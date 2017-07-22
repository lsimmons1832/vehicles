using System;
using System.Collections.Generic;
using vehicles.Vehicles;

namespace vehicles
{
    class Program
    {
        public static void Main()
        {

            // Build a collection of all vehicles that fly
                var airBound = new List<IAirBound> {
                    new Cessna(), 
                    new Helicopter()
                    };

            // With a single `foreach`, have each vehicle Fly()
                foreach (var vehicle in airBound)
                {
                    vehicle.Fly();
                    Console.WriteLine();
                    vehicle.Land();
                }


            // Build a collection of all vehicles that operate on roads
                var roadWarriors = new List<IDrivableVehicle> {
                    new Motorcycle(), 
                    new Delorean()
                    };

            // With a single `foreach`, have each road vehicle Drive()
                foreach (var vehicle in roadWarriors)
                {
                    vehicle.Drive();
                    vehicle.Stop();
                    Console.WriteLine();
                }


            // Build a collection of all vehicles that operate on water

            var waterVehicles = new List<IFloat>{
                new JetSki()
            };

            // With a single `foreach`, have each water vehicle Drive()
            foreach (var vehicle in waterVehicles)
            {
                vehicle.Start();
                
                var drivableVehicle = vehicle as IDrivableVehicle;
                if(drivableVehicle != null){
                    drivableVehicle.Drive();
                    drivableVehicle.Stop();
                }
            }
        }

    }
}
