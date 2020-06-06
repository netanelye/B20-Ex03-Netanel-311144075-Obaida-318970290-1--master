using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        private const int k_MaxWeheelAirPressure = 28;
        private const int k_NumberOfWheels = 16;
        private const eGasType k_GasType = eGasType.Soler;
        private const float k_MaxAmountOfGas = 120f;

        //From user
        private bool m_IsConatiningDangerousMaterials;
        private float m_LuggageCapacity;

        public Truck(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine)
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
            //m_IsConatiningDangerousMaterials
            //m_LuggageCapacity
        }
    }
}
