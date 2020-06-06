using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        // parameters indexes
        private const int k_LicenceTypeIndexInParameters = 4;
        private const int k_EngineVolumeIndexInParameters = 5;

        private const int k_MinEngineVolume = 0;
        private const int k_NumberOfWheels = 2;
        private const int k_MaxWeheelAirPressure = 30;
        private const eGasType k_GasType = eGasType.Octan95;
        private const float k_MaxAmountOfGas = 7;
        private const float k_BatteryCapactity = 1.2f;

        // From user
        private eLicenseType m_LicenceType;
        private int m_EngineVolume;

        public Motorcycle(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine)
        {
            m_Wheels = new Wheel[k_NumberOfWheels];
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i] = new Wheel(k_MaxWeheelAirPressure);
            }

            m_Questions.Add("License type");
            m_Questions.Add("Engine volume");
        }

        public override void SetData(List<string> i_Parameters)
        {
            base.SetData(i_Parameters);
            Enum.TryParse<eLicenseType>(i_Parameters[k_LicenceTypeIndexInParameters], out m_LicenceType); // exception?
            int.TryParse(i_Parameters[k_EngineVolumeIndexInParameters], out m_EngineVolume);
            float currentAirPressure;
            float.TryParse(i_Parameters[k_CurrentAirPressureIndexInParameters], out currentAirPressure); // tryParse really needed?
            for (int i = 0; i < k_NumberOfWheels; i++)
            {
                m_Wheels[i].ManufatorerName = i_Parameters[k_ManufactorerNameIndexInParameters];
                m_Wheels[i].CurrentAirPressure = currentAirPressure;
            }

            if (m_Engine is GasEngine)
            {
                (m_Engine as GasEngine).GasType = k_GasType;
                (m_Engine as GasEngine).MaxAmountOfEnergy = k_MaxAmountOfGas;
            }
            else
            {
                (m_Engine as ElectricEngine).MaxAmountOfEnergy = k_BatteryCapactity;
            }
        }
    }
}
