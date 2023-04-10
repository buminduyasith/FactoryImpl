using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryImpl.Interfaces
{
    internal interface IVehicle
    {
        string VehicleType { get; set; }

        void Excute();
    }
}
