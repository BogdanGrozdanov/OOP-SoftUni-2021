using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        private const string DefautGender = "male";
        public Tomcat(string name, int age)
            : base(name, age, DefautGender)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
