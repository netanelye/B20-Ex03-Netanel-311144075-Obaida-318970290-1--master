using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        //Must In ctor
        protected Engine m_Engine;
        protected readonly string m_LicenseNumber;
        protected Wheel[] m_Wheels;
        protected string m_ModelName;
        protected List<string> m_Parameters;

        public List<string> Parameters
        {
            get
            {
                return m_Parameters;
            }
        }

        protected Vehicle(string i_LicenseNumber, Engine i_Engine)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_Engine = i_Engine;
            m_Parameters = new List<string>();
        }

        public virtual void SetData(List<string> i_Parameters)
        {
            //m_ModelName = 
        }

        public string Model
        {
            get
            {
                return m_ModelName;
            }

            set
            {
                m_ModelName = value;
            }
        }
        public float EnergyPercentage
        {
            get
            {
                return (m_Engine.LeftEnergy / m_Engine.MaxAmountOfEnergy) * 100;
            }
        }

        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
        }

        public string GetWheelsInfo()
        {
            if (m_Wheels != null)
            {
                StringBuilder WheelsInfo = new StringBuilder();
                foreach (Wheel wheel in m_Wheels)
                {
                    WheelsInfo.AppendFormat(wheel.ToString());
                }
                return WheelsInfo.ToString();
            }
            return string.Empty;
        }

    }
}
