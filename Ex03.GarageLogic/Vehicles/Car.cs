using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class Car : Vehicle
    {
        // parameters indexes
        private const int k_ColorIndexInParameters = 4;
        private const int k_NumberOfDoorsIndexInParameters = 5;

        private const int k_MaxWeheelAirPressure = 32;
        private const int k_NumberOfWheels = 4;
        private const float k_BatteryCapactity = 2.1f;
        private const float k_MaxAmountOfGas = 60;
        private const eGasType k_GasType = eGasType.Octan96;

        // From user
        private eColorType m_Color;
        private eNumberOfDoors m_NumberOfDoors;

        public Car(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine)
        {   
            m_Wheels = new Wheel[k_NumberOfWheels];
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i] = new Wheel(k_MaxWeheelAirPressure);
            }

            m_Questions.Add("color");
            m_Questions.Add("number of doors");
        }

        public override void SetData(List<string> i_Parameters)
        {
            base.SetData(i_Parameters);
            Enum.TryParse<eColorType>(i_Parameters[k_ColorIndexInParameters], out m_Color); // exception?
            Enum.TryParse<eNumberOfDoors>(i_Parameters[k_NumberOfDoorsIndexInParameters], out m_NumberOfDoors);
            float currentAirPressure;
            float.TryParse(i_Parameters[k_CurrentAirPressureIndexInParameters], out currentAirPressure); // tryParse really needed?
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i].ManufatorerName = i_Parameters[k_ManufactorerNameIndexInParameters];
                m_Wheels[i].CurrentAirPressure = currentAirPressure;
            }

            if (m_Engine is GasEngine)
            {
                (m_Engine as GasEngine).GasType = k_GasType;
                (m_Engine as GasEngine).MaxAmountOfEnergy = k_MaxAmountOfGas;
            }
            else
            {
                (m_Engine as ElectricEngine).MaxAmountOfEnergy = k_BatteryCapactity;
            }
        }

        public eNumberOfDoors NumberOfDoors
        {
            set
            {
                m_NumberOfDoors = value;
            }
        }

        public eColorType Color
        {
            set
            {
                m_Color = value;
            }
        }
    }
}
