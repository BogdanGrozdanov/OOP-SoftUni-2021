using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : StationaryPhone, ISmartphone, IStationaryPhone
    {
        private string url;
        public string URL
        {
            get { return this.url; }
            private set
            {
                ThrowIfURLIsInvalid(value);
                this.url = value;
            }
        }
        public Smartphone(string number) : base(number)
        {

        }
        public Smartphone(string number, string url) : base(number)
        {
            this.URL = url;

        }



        private void ThrowIfURLIsInvalid(string URL)
        {
            var charURL = URL.ToCharArray();
            for (int i = 0; i < URL.Length; i++)
            {
                if (Char.IsDigit(URL[i]))
                {
                    throw new ArgumentException("Invalid URL!");
                }
            }
        }

        public string MakeCall()
        {
            return $"Calling... {this.PhoneNumber}";
        }

        public string Browsing()
        {


            return $"Browsing: {this.URL}!";

        }
    }

}
