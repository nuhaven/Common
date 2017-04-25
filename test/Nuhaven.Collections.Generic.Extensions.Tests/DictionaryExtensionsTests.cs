using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using Xunit;

namespace Nuhaven.Collections.Generic.Extensions.Tests
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void AddKeyValuePair()
        {
            const int expectedKey = 1;
            const string expectedValue = "test";

            var dict = new Dictionary<int, string>();

            Assert.False(dict.ContainsKey(expectedKey));
            Assert.False(dict.ContainsValue(expectedValue));

            var kvp = new KeyValuePair<int, string>(expectedKey, expectedValue);
            dict.Add(kvp);

            Assert.True(dict.ContainsKey(expectedKey));
            Assert.True(dict.ContainsValue(expectedValue));
        }

        [Fact]
        public void AddKeyValuePairThrowsIfItHasANullKey()
        {
            var dict = new Dictionary<string, string>();
            var kvp = new KeyValuePair<string, string>(null, "test");
            Assert.Throws<ArgumentNullException>(() =>
                dict.Add(kvp)
            );
        }

        [Fact]
        public void AddKeyValuePairThrowsIfTheKeyAlreadyExists()
        {
            var dict = new Dictionary<int, int>();
            var kvp = new KeyValuePair<int, int>(0, 1234);
            dict.Add(kvp);

            Assert.Throws<ArgumentException>(() =>
                dict.Add(kvp)
            );
        }

        [Fact]
        public void AddKeyValuePairThrowsOnAReadOnlyDictionary()
        {
            var dict = new Dictionary<int, int>();

            var readOnlyDict = new ReadOnlyDictionary<int, int>(dict);
            var kvp = new KeyValuePair<int, int>(0, 1234);

            Assert.Throws<NotSupportedException>(() =>
                readOnlyDict.Add(kvp)
            );
        }

        [Fact]
        public void AddKeyValuePairThrowsOnAnImmutableDictionary()
        {
            var dict = new Dictionary<int, int>();

            var immutableDict = dict.ToImmutableDictionary();
            var kvp = new KeyValuePair<int, int>(0, 1234);

            Assert.Throws<NotSupportedException>(() =>
                immutableDict.Add(kvp)
            );
        }
    }
}
