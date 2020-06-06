using Ex03.GarageLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic 
{
    public class Wheel
    {
        private readonly string r_ManufactorerName;
        private float m_CurrentAirPressure;
        private readonly float r_MaximumAirPressure;
        private readonly float r_MinimumAirPressure;
        public Wheel(float i_MaxAirPressure)
        {
            r_MaximumAirPressure = i_MaxAirPressure;
        }

        public Wheel(string i_Manufactorer, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            r_ManufactorerName = i_Manufactorer;
            m_CurrentAirPressure = i_CurrentAirPressure;
            r_MaximumAirPressure = i_MaxAirPressure;
        }

        public bool Inflate(float i_AirToAdd)
        {
            bool inflatingSucceeded = i_AirToAdd + m_CurrentAirPressure <= r_MaximumAirPressure;
            if(inflatingSucceeded)
            {
                m_CurrentAirPressure += i_AirToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(r_MinimumAirPressure, r_MaximumAirPressure);
            }
            return inflatingSucceeded;
        }
    }
}
