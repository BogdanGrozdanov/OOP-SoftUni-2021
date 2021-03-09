using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                ThrowIfNumberIsInvalid(value);
                this.phoneNumber = value;
            }
        }
        public StationaryPhone(string number)
        {
            this.PhoneNumber = number;
        }

        private void ThrowIfNumberIsInvalid(string digits)
        {
            var charDigits = digits.ToCharArray();
            for (int i = 0; i < charDigits.Length; i++)
            {
                if (!Char.IsDigit(charDigits[i]))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }
        }

        public string MakeCall()
        {
            return $"Dialing... {this.PhoneNumber}";
        }
    }
}
