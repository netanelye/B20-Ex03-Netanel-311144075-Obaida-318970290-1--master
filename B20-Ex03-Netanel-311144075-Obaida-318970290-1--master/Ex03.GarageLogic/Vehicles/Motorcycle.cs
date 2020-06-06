using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        private const int k_MinEngineVolume = 0;
        private const int k_NumberOfWheels = 2;
        private const int k_MaxWeheelAirPressure = 30;
        private const eGasType k_GasType = eGasType.Octan95;
        private const float k_MaxAmountOfGas = 7;
        private const float k_BatteryCapactity = 1.2f;

        //From user
        private eLicenseType m_licenceType;
        private int m_EngineVolume;

        public Motorcycle(string i_LicenseNumber, Engine i_Engine):base(i_LicenseNumber, i_Engine)
        {
            m_Wheels = new Wheel[k_NumberOfWheels];
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i] = new Wheel(k_MaxWeheelAirPressure);
            }

            
        }

        public override void SetData()
        {
            base.SetData();
            //if (i_Engine is GasEngine)
            //{
            //    (m_Engine as GasEngine).GasType = k_GasType;
            //    (m_Engine as GasEngine).MaxAmountOfEnergy = k_MaxAmountOfGas;
            //    //(m_Engine as GasEngine).CurrentAmountOfEnergy =
            //}
            //else
            //{
            //    (m_Engine as ElectricEngine).MaxAmountOfEnergy = k_BatteryCapactity;
            //    //(m_Engine as ElectricEngine).CurrentAmountOfEnergy
            //}
        }
    }
}
