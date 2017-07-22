namespace vehicles.Vehicles
{
    public interface IAirBound : IVehicle
    {
        bool Winged { get; set;}
        double MaxSpeed { get; set;}
        void Fly();
    }
}