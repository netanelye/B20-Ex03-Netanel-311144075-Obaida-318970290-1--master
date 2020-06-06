using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class GasEngine : Ex03.GarageLogic.Engine
    {
        private eGasType m_GasType;
        
        public bool Refuel(int i_AmountOfGasToAddToAdd, eGasType i_FuelType)
        {
            bool fuelOverflow = m_CurrentAmountOfEnergy + i_AmountOfGasToAddToAdd > m_MaxAmountOfEnergy;
            bool appropriateFuelType = i_FuelType == m_GasType;
            bool isRefuelSucceeded = !fuelOverflow && appropriateFuelType;
            if (isRefuelSucceeded)
            {
                m_CurrentAmountOfEnergy += i_AmountOfGasToAddToAdd;
            }

            return isRefuelSucceeded;
        }

        public eGasType GasType
        {
            get
            {
                return m_GasType;
            }

            set
            {
                m_GasType = value;
            }
        }
    }
}
