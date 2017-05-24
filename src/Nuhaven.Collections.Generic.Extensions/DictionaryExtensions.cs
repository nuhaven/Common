using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuhaven.Collections.Generic
{
    /// <summary>
    /// Extensions for the IDictionary
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds a key-value-pair instance to a dictionary
        /// </summary>
        /// <param name="dict">The IDictionary instance</param>
        /// <param name="kvp">A key-value-pair to add</param>
        /// <typeparam name="K">The dictionary key type</typeparam>
        /// <typeparam name="V">The dictionary value type</typeparam>
        /// <exception cref="T:System.ArgumentNullException">key is null</exception>
        /// <exception cref="T:System.ArgumentException">
        /// An element with the same key already exists in the IDictionary object
        /// </exception>
        /// <exception cref="T:System.NotSupportedException">
        /// The IDictionary is read-only or the IDictionary has a fixed size.
        /// </exception>
        public static void Add<K, V>(this IDictionary<K, V> dict, KeyValuePair<K, V> kvp) =>
            dict.Add(kvp.Key, kvp.Value);
    }
}
