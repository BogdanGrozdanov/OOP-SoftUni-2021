using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public interface IStationaryPhone
    {
        public string PhoneNumber { get; }

        string MakeCall();
    }
}
