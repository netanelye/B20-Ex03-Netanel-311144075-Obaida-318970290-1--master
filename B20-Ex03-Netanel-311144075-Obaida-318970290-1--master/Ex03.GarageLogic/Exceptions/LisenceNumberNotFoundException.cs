using System;
using System.Collections.Generic;

namespace Ex03.GarageLogic.Exceptions
{
    public class LisenceNumberNotFoundException : Exception
    {
        private readonly string m_LisenceNumber;

        public LisenceNumberNotFoundException(string i_LisenceNumber)
        {
            m_LisenceNumber = i_LisenceNumber;
        }

        
        public override string Message
        {
            get
            {
                string message = string.Format(
                                                 @"The Vehicle with lisence number 
                                                      {0} does not exist in the garage.",
                                                    m_LisenceNumber);
                return message;
            }
        }
    }
}