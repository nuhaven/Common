using System;
using System.Collections.Generic;
using Xunit;

namespace Nuhaven.Collections.Generic.Extensions.Tests
{
    public class EnumerableExtensionsTests
    {
        public static IEnumerable<object[]> TestEnumerableIsEmptyOrNullData() =>
            new[] {
                new object[] {true, null},
                new object[] {true, new List<int>()},
                new object[] {false, new List<string>{"test"}},
                new object[] {false, new List<int>{1, 2, 3, 4}},
                new object[] {false, new[] {"str"}}
            };

        [Theory]
        [MemberData(nameof(TestEnumerableIsEmptyOrNullData))]
        public void TestListArrayIsEmpty<T>(object expectedIsEmptyOrNull, IEnumerable<T> enumerable)
        {
            var actualIsEmptyOrNull = enumerable.IsNullOrEmpty();
            Assert.Equal(expectedIsEmptyOrNull, actualIsEmptyOrNull);
        }

        public static IEnumerable<object[]> TestDictionaryIsEmptyData() =>
            new[] {
                new object[] {true, null},
                new object[] {true, new Dictionary<int, int>()},
                new object[] {false, new Dictionary<int, string>{
                    [1] = "test"
                }}
            };

        [Theory]
        [MemberData(nameof(TestDictionaryIsEmptyData))]
        public void TestDictionaryIsEmpty<K,V>(object expectedIsEmptyOrNull, IDictionary<K,V> dictionary)
        {
            var actualIsEmptyOrNull = dictionary.IsNullOrEmpty();
            Assert.Equal(expectedIsEmptyOrNull, actualIsEmptyOrNull);
        }
    }
}
