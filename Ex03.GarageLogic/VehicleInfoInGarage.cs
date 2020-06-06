using System.Text;
using Ex03.GarageLogic.Enums;

namespace Ex03.GarageLogic
{
    internal class VehicleInfoInGarage
    {
        private Owner m_Owner;
        private Vehicle m_Vechile;
        private eVehicleStatus m_Status;
        
        public VehicleInfoInGarage(Owner i_Owner, Vehicle i_Vehicle)
        {
            m_Owner = i_Owner;
            m_Vechile = i_Vehicle;
            m_Status = eVehicleStatus.InRepair;
        }

        public eVehicleStatus Status
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

        public string VehicleLicenseNumber
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
            infoAsString.AppendFormat(", owner: {0} ", m_Owner.Name);
            infoAsString.AppendFormat(", car status: {0}", m_Status.ToString());
            infoAsString.AppendFormat(", wheels status: {0} ", m_Vechile.GetWheelsInfo());
            /// & more...
            return infoAsString.ToString();
        }
    }
}
