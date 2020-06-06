using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Exceptions;

namespace Ex03.GarageLogic 
{
    public class Wheel
    {
        private const float m_MinimumAirPressure = 0; 
        private readonly float r_MaximumAirPressure;
        private string m_ManufactorerName;
        private float m_CurrentAirPressure;

        public Wheel(float i_MaxAirPressure)
        {
            r_MaximumAirPressure = i_MaxAirPressure;
        }

        public Wheel(string i_Manufactorer, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            m_ManufactorerName = i_Manufactorer;
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
                throw new ValueOutOfRangeException(m_MinimumAirPressure, r_MaximumAirPressure);
            }

            return inflatingSucceeded;
        }

        public string ManufatorerName
        {
            get
            {
                return m_ManufactorerName;
            }

            set
            {
                m_ManufactorerName = value;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return m_CurrentAirPressure;
            }

            set
            {
                m_CurrentAirPressure = value;
            }
        }

        public float MaxAirPressure
        {
            get
            {
                return r_MaximumAirPressure;
            }
        }
    }
}
