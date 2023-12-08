using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class SelectTest
    {
        [Fact]
        public void CollectionWithElements_SelectIncremented_Success()
        {
            var items = new[] { 1, 2, 3 };

            var results = items.Select(o => o + 1);

            Assert.Equal(new int[] { 2, 3, 4 }, results);
        }

        [Fact]
        public void CollectionWithIntElements_SelectAsString_Success()
        {
            var items = new[] { 1, 2, 3 };

            var result = items.Select(o => $"Привет {o}");

            Assert.Equal(new string[] { "Привет 1", "Привет 2", "Привет 3" }, result);
        }
    }
}
