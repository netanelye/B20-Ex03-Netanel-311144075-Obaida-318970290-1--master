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
        private readonly GarageLogicManager r_Garage;
       
        public GarageManager()
        {
            r_Garage = new GarageLogicManager();
        }

        public void Run()
        {
            Console.WriteLine(
                string.Format(
                    @"Welcome to garage
                    Choose on of the following options below{0}", Environment.NewLine));
            int userChoice;
            while (true)
            {
                showManu();
                userChoice = GetChoiceToManu();
                switch (userChoice)
                {
                    case (int)eManuOptions.AddNewVehicle:
                        {
                            addNewVehicle();
                            break;
                        }
                }
            }

            
        }

        private void addNewVehicle()
        {
            Console.Clear();
            // print - "insert license number"
            string licenseNumber = Console.ReadLine();
            // print - "choose vehicle type"
            showManuOfVehicles();
            eVehiclesType vehicleType = (eVehiclesType)getChoiceFromUser();
            Owner owner = getOwnerFromUser();
            //create new car
            r_Garage.AddNewCar(licenseNumber, vehicleType, owner);
            List<string> parameters = r_Garage.GetParameters(licenseNumber);
            List<string> inputsFromUser = new List<string>(parameters.Count);
            foreach (string question in parameters)
            {
                Console.Write(string.Format("{0} ", question));
                inputsFromUser.Add(Console.ReadLine());
            }

            r_Garage.SetVehicleData(licenseNumber, inputsFromUser);
            Console.WriteLine("Vehicle added successfuly");
        }

        private Owner getOwnerFromUser()
        {
            Console.WriteLine("Insert owner's name: ");
            string ownerName = Console.ReadLine();
            Console.WriteLine("Insert owner's phone number: ");
            string ownerPhone = Console.ReadLine();

            return new Owner(ownerName, ownerPhone);
        }

        private void showManuOfVehicles()
        {
            foreach (string vehcletypeName in Enum.GetNames(typeof(eVehiclesType)))
            {
                Console.WriteLine(vehcletypeName);
            }
        }
        private int getChoiceFromUser()
        {
            int choice;
            bool legalIntInput = int.TryParse(Console.ReadLine(), out choice);
            
            return choice;
        }
    }

    enum eManuOptions
    {
        AddNewVehicle = 1,
        PrintLicenseNumbes,
        ChangeVehicleStatus,
        InflateToMax,
        Refuel,
        Charge,
        PrintVehicleData
    }
}
