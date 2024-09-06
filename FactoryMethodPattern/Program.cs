


using FactoryMethodPattern.Models;

var vehicleFactory = new VehicleFactory();


IVehicle car = vehicleFactory.CreateVehicle(VehicleType.Car);
car.DisplayInfo();



IVehicle truck = vehicleFactory.CreateVehicle(VehicleType.Truck);
truck.DisplayInfo();


Console.ReadLine();