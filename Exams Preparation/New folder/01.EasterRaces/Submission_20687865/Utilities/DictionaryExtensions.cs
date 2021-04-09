using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Utilities
{
    public static class DictionaryExtensions
    {
        public static TValue GetByKeyOrDefaut<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue result = default;
            if (dictionary.ContainsKey(key))
            {
                result = dictionary[key];
            }
            return result;
        }
    }
}
