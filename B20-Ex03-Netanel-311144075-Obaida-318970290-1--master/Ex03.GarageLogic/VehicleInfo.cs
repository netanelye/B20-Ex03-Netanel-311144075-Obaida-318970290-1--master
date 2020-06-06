using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    internal class VehicleInfo
    {
        private readonly string m_OwnerName;
        private readonly string m_PhoneNumber;
        private readonly Vehicle m_Vechile;
        private eCarStatus m_Status;
        
        public VehicleInfo(string i_OwnerName, string i_PhoneNumber, Vehicle i_Vehicle)
        {
            m_OwnerName = i_OwnerName;
            m_PhoneNumber = i_PhoneNumber;
            m_Vechile = i_Vehicle;
            m_Status = eCarStatus.InRepair;
        }

        public eCarStatus Status
        {
            get
            {
                return m_Status;
            }

            set
            {
                m_Status = value;
            }
        }

        public string CarLicenseNumber
        {
            get
            {
                return m_Vechile.LicenseNumber;
            }
        }

        public Vehicle Vehicle
        {
            get
            {
                return m_Vechile;
            }
        }

        public override string ToString()
        {
            StringBuilder infoAsString = new StringBuilder();
            infoAsString.AppendFormat("License number: {0}", m_Vechile.LicenseNumber);
            infoAsString.AppendFormat(", car model: {0} ", m_Vechile.Model);
            infoAsString.AppendFormat(", owner: {0} ", m_OwnerName);
            infoAsString.AppendFormat(", car status: {0}", m_Status.ToString());
            infoAsString.AppendFormat(", wheels status: {0} ", m_Vechile.GetWheelsInfo());
            /// & more...
            return infoAsString.ToString();
        }
    }
}
