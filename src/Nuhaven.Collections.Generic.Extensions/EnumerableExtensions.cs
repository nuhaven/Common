using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuhaven.Collections.Generic
{
    /// <summary>
    /// Extensions for the IEnumerable
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Tells if a Enumerable is null or empty
        /// </summary>
        /// <typeparam name="T">The value type of enumerable</typeparam>
        /// <param name="value">The IEnumerable instance</param>
        /// <returns>Returns true if the enumerable is empty or null</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> value) =>
            null == value || !value.Any();
    }
}
