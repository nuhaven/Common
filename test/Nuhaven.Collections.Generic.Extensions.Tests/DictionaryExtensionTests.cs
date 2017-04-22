using System;
using System.Collections.Generic;
using Xunit;

namespace Nuhaven.Collections.Generic.Extensions.Tests
{
    public class DictionaryExtensionsTests
    {
        [Fact]
        public void TestDictionaryAnAddKeyValuePair()
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
    }
}
