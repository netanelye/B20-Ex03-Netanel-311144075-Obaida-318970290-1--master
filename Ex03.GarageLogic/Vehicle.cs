using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        protected const int k_ModelNameIndexInParameters = 0;
        protected const int k_LeftEnergyIndexInParameters = 1;
        protected const int k_ManufactorerNameIndexInParameters = 2;
        protected const int k_CurrentAirPressureIndexInParameters = 3;

        //Must In ctor
        protected readonly string r_LicenseNumber;
        protected Engine m_Engine;
        protected Wheel[] m_Wheels;
        protected string m_ModelName;
        protected List<string> m_Questions;

        public List<string> Parameters
        {
            get
            {
                return m_Questions;
            }
        }

        protected Vehicle(string i_LicenseNumber, Engine i_Engine)
        {
            r_LicenseNumber = i_LicenseNumber;
            m_Engine = i_Engine;
            m_Questions = new List<string>();
            m_Questions.Add("Model name");
            m_Questions.Add("Left energy in engine");
            m_Questions.Add("Name of manufatorer of wheels");
            m_Questions.Add("Current air pressure in wheels");
        }

        public virtual void SetData(List<string> i_Parameters)
        {
            m_ModelName = i_Parameters[k_ModelNameIndexInParameters];
            m_Engine.LeftEnergy = float.Parse(i_Parameters[k_LeftEnergyIndexInParameters]);
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
                return r_LicenseNumber;
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
