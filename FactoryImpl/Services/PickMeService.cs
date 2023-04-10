using FactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryImpl.Services
{
    internal class PickMeService : IPickMeService
    {
        private readonly IVehicleFactory vehicleFactory;
        private IVehicle vehicle;

        public PickMeService(IVehicleFactory vehicleFactory)
        {
            this.vehicleFactory = vehicleFactory;
        }

        public void GetDetails()
        {
            vehicle = vehicleFactory.Create("Car");
            vehicle.Excute();
        }
    }
}
