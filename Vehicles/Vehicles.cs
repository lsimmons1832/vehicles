using System;
using System.Collections.Generic;

namespace vehicles.Vehicles
{
    public class Vehicle
    {
        public string Name {get; set;}

        List<Vehicle> Vehicles {get; set;} = new List<Vehicle>();
    }
}