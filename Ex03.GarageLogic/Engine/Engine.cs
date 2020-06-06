using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic 
{
    public abstract class Engine
    {
        protected float m_MaxAmountOfEnergy; 
        protected float m_CurrentAmountOfEnergy; 

        public float LeftEnergy
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

        public float MaxAmountOfEnergy
        {
            get
            {
                return m_MaxAmountOfEnergy;
            }

            set
            {
                m_MaxAmountOfEnergy = value;
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
