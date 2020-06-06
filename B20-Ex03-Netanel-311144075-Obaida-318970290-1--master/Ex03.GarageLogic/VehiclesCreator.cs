using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class VehiclesCreator
    {
        
        public VehiclesCreator()
        {

        
        }

        public Vehicle CreateNewVehicle(string i_LicenseNumber, eVehiclesType i_VehicleType)
        {
            Vehicle vehicle;
            switch (i_VehicleType)
            {
                case eVehiclesType.GasCar:
                {
                    vehicle = new Car(i_LicenseNumber, new GasEngine());
                    break;
                }
                case eVehiclesType.ElectricCar:
                {
                    vehicle = new Car(i_LicenseNumber, new ElectricEngine());
                    break;
                }
                case eVehiclesType.GasMotorcycle:
                {
                    vehicle = new Motorcycle(i_LicenseNumber, new GasEngine());
                    break;
                }
                case eVehiclesType.ElectricMotorcycle:
                {
                    vehicle = new Motorcycle(i_LicenseNumber, new ElectricEngine());
                    break;
                }
                case eVehiclesType.Truck:
                {
                    vehicle = new Truck(i_LicenseNumber, new GasEngine());
                    break;
                }
                default:
                {
                    vehicle = null;
                    break;
                }
            }

            return vehicle;
        }

        public bool needToAskUserForDoorsNumber
        {
            get
            {
                return true;
            }
        }


    }
}
