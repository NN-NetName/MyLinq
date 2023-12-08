using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class AnyTest
    {
        [Fact]
        public void EmptyCollection_Any_ReturnsTrue()
        {
            var item = new int[5];
            var result = item.Any();

            Assert.True(result);
        }
        [Fact]
        public void CollectionWithElements_ThereIsAnyElement()
        {
            var item = new[] { 1, 2, 3, 4 };
            var result = item.Any(item => item == 2);

            Assert.True(result);
        }

        [Fact]
        public void CollectionWithElements_IsThereNoAnyElement()
        {
            var item = new[] { 1, 2, 3, 4 };
            var result = item.Any(item => item == 10);

            Assert.False(result);
        }

        [Fact]
        public void CollectionWithoutElements_Any_ReturnsFalse()
        {
            var item = new int[0];

            Assert.False(item.Any());
        }
    }
}
