using System;
using System.Linq;
using System.Collections.Generic;


namespace vehicles.Vehicles
{
    public interface IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        void Start();

    }
}