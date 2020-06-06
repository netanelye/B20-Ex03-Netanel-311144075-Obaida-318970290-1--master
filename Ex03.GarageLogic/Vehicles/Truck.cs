using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private const int k_DangerousMaterialsIndexInParameters = 4;
        private const int k_LuggageCapacityIndexInParameters = 5;

        private const int k_MaxWeheelAirPressure = 28;
        private const int k_NumberOfWheels = 16;
        private const eGasType k_GasType = eGasType.Soler;
        private const float k_MaxAmountOfGas = 120f;

        /// From user
        private bool m_IsConatiningDangerousMaterials;
        private float m_LuggageCapacity;

        public Truck(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine)
        {
            m_Wheels = new Wheel[k_NumberOfWheels];
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i] = new Wheel(k_MaxWeheelAirPressure);
            }

            m_Questions.Add("Does this truck carry dangerous materials? ");
            m_Questions.Add("Luggage capacity ");
        }

        public override void SetData(List<string> i_Parameters)
        {
            base.SetData(i_Parameters);
            bool.TryParse(i_Parameters[k_DangerousMaterialsIndexInParameters], out m_IsConatiningDangerousMaterials);
            float.TryParse(i_Parameters[k_LuggageCapacityIndexInParameters], out m_LuggageCapacity);
            float currentAirPressure;
            float.TryParse(i_Parameters[k_CurrentAirPressureIndexInParameters], out currentAirPressure); ///tryParse really needed?
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i].ManufatorerName = i_Parameters[k_ManufactorerNameIndexInParameters];
                m_Wheels[i].CurrentAirPressure = currentAirPressure;
            }

            (m_Engine as GasEngine).GasType = k_GasType;
            (m_Engine as GasEngine).MaxAmountOfEnergy = k_MaxAmountOfGas;
        }
    }
}
