using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList(IEnumerable<string> phrase) : base(phrase)
        {
            rnd = new Random();
        }
        public string RandomString()
        {
            string result = string.Empty;
            int index = rnd.Next(0, this.Count);
            result = this[index];
            this.RemoveAt(index);
            return result;
        }

    }
}
