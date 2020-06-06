using System;

namespace Ex03.GarageLogic.Exceptions
{

    public class CarWithoutLisenceNumberException : Exception
    {
        private readonly Owner m_Owner;

        public CarWithoutLisenceNumberException(Owner i_Owner)
        {
            m_Owner = i_Owner;
        }

        public override string Message
        {
            get
            {
                return string.Format("The Owner \"{0}\" has vehicle that does not have lisence number.", m_Owner.ToString());
            }
        }
    }
}