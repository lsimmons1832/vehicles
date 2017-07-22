using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles.Vehicles
{
    public class JetSki : IFloat, IDrivableVehicle
    {
        public int Wheels { get; set;} = 0;
        public int Doors { get; set;} = 0;        
        public int PassengerCapacity { get; set;} = 1;
        public string TransmissionType { get ; set;} = "Variable";
        public double EngineVolume { get ; set;} = 1.1;
        public double MaxSpeed { get; set;} = 42;

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Start()
        {
            Console.WriteLine("Hey y'all watch this!!");
        }

        public void Stop()
        {
            Console.WriteLine("Call 911!!!!!");
        }
    }
}