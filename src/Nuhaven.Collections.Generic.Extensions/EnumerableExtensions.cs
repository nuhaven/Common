using System;
using System.Collections.Generic;
using System.Linq;

namespace Nuhaven.Collections.Generic
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Tells if a Enumerable is null or empty
        /// </summary>
        /// <param name="value">The IEnumerable instance</param>
        /// <returns>Returns true if the enumerable is empty or null</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> value) =>
            null == value || !value.Any();
    }
}
