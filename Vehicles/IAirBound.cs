namespace vehicles.Vehicles
{
    public interface IAirBound
    {
        int PassengerCapacity { get;}
        bool Winged { get;}
        double EngineVolume { get;}
        double MaxAirSpeed { get;}
    }
}