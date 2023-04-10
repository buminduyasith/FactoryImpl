using FactoryImpl.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryImpl.Services
{
    internal class VehicleFactory : IVehicleFactory
    {
        private readonly Func<IEnumerable<IVehicle>> _factory;
        public VehicleFactory(Func<IEnumerable<IVehicle>> factory)
        {
            _factory = factory ?? throw new ArgumentNullException();
        }

        public IVehicle Create(string type)
        {
            var set = _factory();
            IVehicle vehicle = set.Where(x=>x.VehicleType== type).First();
            return vehicle; 
        }
    }
}
