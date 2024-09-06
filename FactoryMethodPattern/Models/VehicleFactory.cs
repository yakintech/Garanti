using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Models
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(VehicleType vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Truck:
                    return new Truck();
                case VehicleType.Motorcycle:
                    return new Motorcycle();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }
}
