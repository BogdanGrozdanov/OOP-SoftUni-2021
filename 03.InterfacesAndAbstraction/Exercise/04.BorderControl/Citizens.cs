using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Citizens : IIds
    {
        public Citizens(string name, string age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public string Name { get; set; }

        public string Age { get; set; }

        public string Id { get; set; }
    }
}
