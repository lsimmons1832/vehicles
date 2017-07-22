namespace vehicles.Vehicles
{
    public interface IRoadWarrior
    {
        int Wheels {get;}
        int Doors {get;}
        int PassengerCapacity {get;}
        string TransmissionType { get;}
        double EngineVolume { get;}
        double MaxLandSpeed { get;}
    }
}