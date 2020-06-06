using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic.Exceptions
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;
        private string m_Message;

        public ValueOutOfRangeException(float i_MaxValue, float i_MinValue)
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
            /// base = new Exception()
        }

        public override string Message
        {
            get
            {
                return base.Message;
            }
        }
    }
}
