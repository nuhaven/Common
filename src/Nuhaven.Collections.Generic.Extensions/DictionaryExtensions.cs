using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuhaven.Collections.Generic
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds a key-value-pair instance to a dictionary
        /// </summary>
        /// <param name="dict">The IDictionary instance</param>
        /// <param name="kvp">A key-value-pair to add</param>
        public static void Add<K, V>(this IDictionary<K, V> dict, KeyValuePair<K, V> kvp) =>
            dict.Add(kvp.Key, kvp.Value);
    }
}
