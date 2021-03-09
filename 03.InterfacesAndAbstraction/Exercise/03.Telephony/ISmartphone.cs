using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public interface ISmartphone : IStationaryPhone
    {
        public string URL { get; }
        public string Browsing();
    }
}
