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
        private const int k_MaxWeheelAirPressure = 32;
        private const int k_NumberOfWheels = 4;
        private const float k_BatteryCapactity = 2.1f;
        private const float k_MaxAmountOfGas = 60;

        //From user
        private eColorType m_Color;
        private eNumberOfDoors m_NumberOfDoors;

        public Car(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine)
        {   
            m_Wheels = new Wheel[k_NumberOfWheels];
            for(int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i] = new Wheel(k_MaxWeheelAirPressure);
            }
            m_Parameters.Add("color");
            m_Parameters.Add("number of doors");
        }

        public override void SetData(List<string> i_Parameters)
        {
            m_ModelName = "bdghtdhdfgtH";
            Enum.TryParse<eColorType>(i_Parameters[0], out m_Color);
            Enum.TryParse<eNumberOfDoors>(i_Parameters[1], out m_NumberOfDoors);

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
