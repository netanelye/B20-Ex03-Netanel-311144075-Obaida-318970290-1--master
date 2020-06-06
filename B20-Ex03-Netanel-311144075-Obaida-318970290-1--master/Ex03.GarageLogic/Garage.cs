using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic.Exceptions;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private readonly Dictionary<string, VehicleInfo> m_VehiclesInfo;
        private readonly StringBuilder i_dataToShowToUser;
        
        public Garage()
        {
            m_VehiclesInfo = new Dictionary<string, VehicleInfo>();
            i_dataToShowToUser = new StringBuilder();
        }

        public void AddNewCar(Vehicle i_Vehicle, Owner i_Owner)
        {
            string licenseNumber = i_Vehicle.LicenseNumber;
            bool isExists = m_VehiclesInfo.ContainsKey(licenseNumber);
            if (string.IsNullOrEmpty(licenseNumber))
            {
                throw new CarWithoutLisenceNumberException(i_Owner);
            }
            else if (isExists)
            {
                Console.WriteLine("Vehicle license-number {0} already exist", licenseNumber);
                ChangeVeichleStatus(licenseNumber, eCarStatus.InRepair);
            }
            else
            {
                VehicleInfo newVehicle = new VehicleInfo(i_Owner.Name, i_Owner.PhoneNumber, i_Vehicle);
                m_VehiclesInfo.Add(licenseNumber, newVehicle);
            }
        }

        public void ShowVeichlesInGarage(eCarStatus i_StatusToSort)
        {
            foreach (KeyValuePair<string, VehicleInfo> kvp in m_VehiclesInfo)
            {
                if (kvp.Value.Status == i_StatusToSort)
                {
                    Console.WriteLine("License number = {0} ", kvp.Value.CarLicenseNumber);
                }
            }
        }

        public void ShowVeichlesInGarage()
        {
            foreach (KeyValuePair<string, VehicleInfo> kvp in m_VehiclesInfo)
            {
                Console.WriteLine("License number = {0} ", kvp.Value.CarLicenseNumber);
            }
        }

        public bool ChangeVeichleStatus(string i_LisenceNumber, eCarStatus i_NewStatus)
        {
            bool isExists = m_VehiclesInfo.ContainsKey(i_LisenceNumber);
            if (isExists)
            {
                VehicleInfo vehicleData = m_VehiclesInfo[i_LisenceNumber];
                vehicleData.Status = i_NewStatus;
                m_VehiclesInfo[i_LisenceNumber] = vehicleData;
            }
            else
            {
                throw new LisenceNumberNotFoundException(i_LisenceNumber);
            }

            return isExists;
        }

        public bool BlowUpWheelsToMax(string i_LisenceNumber)
        {
            bool isExists = m_VehiclesInfo.ContainsKey(i_LisenceNumber);
            if (isExists)
            {
                //m_VehiclesInfo[i_LisenceNumber].Vehicle.BlowTheWheels();
            }
            else
            {
                throw new LisenceNumberNotFoundException(i_LisenceNumber);
            }

            return isExists;
        }

        public bool ReFuel(string i_LisenceNumber, eCarStatus i_GasTypeToAdd, float i_AmountOfGasToAdd)
        {
            bool isExists = m_VehiclesInfo.ContainsKey(i_LisenceNumber);
            bool vehicleCanBeReFuel = false;
            if (isExists)
            {
                Engine tank = m_VehiclesInfo[i_LisenceNumber].Vehicle.Engine;
                if (tank is GasEngine)
                {
                    tank.Refuel(i_GasTypeToAdd, i_AmountOfGasToAdd);
                }
            }
            else
            {
                throw new LisenceNumberNotFoundException(i_LisenceNumber);
            }

            return vehicleCanBeReFuel;
        }

        public bool Charge(string i_LisenceNumber, float i_AmountOfMinutesToAdd)
        {
            bool isExists = m_VehiclesInfo.ContainsKey(i_LisenceNumber);
            bool vehicleCanBeCharge = false;
            if (isExists)
            {
                Vehicle vehicle = m_VehiclesInfo[i_LisenceNumber].Vehicle;
                vehicleCanBeCharge = vehicle.CanBeCharge;
                if (vehicleCanBeCharge)
                {
                    vehicle.Charge(i_AmountOfMinutesToAdd);
                }
            }
            else
            {
                throw new LisenceNumberNotFoundException(i_LisenceNumber);
            }

            return vehicleCanBeCharge;
        }

        public bool ShowVehicleData(string i_LisenceNumber)
        {
            bool isExists = m_VehiclesInfo.ContainsKey(i_LisenceNumber);

            i_dataToShowToUser.Clear();
            if (isExists)
            {
                VehicleInfo vehicleInfo = m_VehiclesInfo[i_LisenceNumber];
                Console.WriteLine(vehicleInfo.ToString());
            }
            else
            {
                throw new LisenceNumberNotFoundException(i_LisenceNumber);
            }

            return isExists;
        }

        //public void MakeTest()
        //{
        //    Vehicle car;
        //    for (int i = 0; i < 5; i++)
        //    {
        //
        //        car = new Vehicle(string.Format("45626{0}", i));
        //        AddNewCar(car, new Owner("obaida", "0524388203"));
        //    }
        //
        //    ShowVehicleData("456260");
        //}
    }
}