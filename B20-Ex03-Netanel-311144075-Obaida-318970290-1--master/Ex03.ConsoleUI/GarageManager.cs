using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;
namespace Ex03.ConsoleUI
{
    public class GarageManager
    {
        readonly Garage garage;
        readonly VehiclesCreator vehiclesCreator;

        public GarageManager()
        {
            garage = new Garage();
            vehiclesCreator = new VehiclesCreator();
        }

        public void Run()
        {
            Console.WriteLine("Choose a vehcles from the list below:");
            foreach (string vehcletypeName in Enum.GetNames(typeof(eVehiclesType)))
            {
                Console.WriteLine(vehcletypeName);
            }
            eVehiclesType vehicleType;
            Enum.TryParse<eVehiclesType>(Console.ReadLine(), out vehicleType);
            string licenseNumber = Console.ReadLine();
            Vehicle newVehicle = vehiclesCreator.CreateNewVehicle(licenseNumber, vehicleType);
            List<string> parameters = newVehicle.Parameters;
            List<string> inputs = new List<string>();
            foreach (string input in parameters)
            {
                Console.WriteLine("please type {0} for the vehicle", input);
                inputs.Add(Console.ReadLine());
            }
            newVehicle.SetData(inputs);
        }
    }
}
