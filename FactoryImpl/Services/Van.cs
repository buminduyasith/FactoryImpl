using FactoryImpl.Interfaces;

namespace FactoryImpl.Services
{
    public class Van : IVehicle
    {
        public string VehicleType { get; set; } = "Van";

        public void Excute()
        {
            Console.WriteLine("Van");
        }
    }
}

