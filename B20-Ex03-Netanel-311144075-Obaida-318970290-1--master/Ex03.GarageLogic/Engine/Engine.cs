using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic 
{
    public abstract class Engine
    {
        protected float m_MaxAmountOfEnergy; //m_Capacity
        protected float m_CurrentAmountOfEnergy; // m_RemainingEnergy

        public float LeftEnergy
        {
            get
            {
                return m_CurrentAmountOfEnergy;
            }
        }

        //capacity
        public float MaxAmountOfEnergy
        {
            get
            {
                return m_MaxAmountOfEnergy;
            }
        }

        public float CurrentAmountOfEnergy
        {
            get
            {
                return m_CurrentAmountOfEnergy;
            }

            set 
            {
                m_CurrentAmountOfEnergy = value;
            }
        }
    }
}
