using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Ex03.GarageLogic.Engine
    {
        public bool ChargeBattery(int i_HoursToAdd)
        {
            bool isChargingSucceeded = m_CurrentAmountOfEnergy + i_HoursToAdd <= m_MaxAmountOfEnergy;
            if(isChargingSucceeded)
            {
                m_CurrentAmountOfEnergy += i_HoursToAdd;
            }

            return isChargingSucceeded;
        }
    }
}
