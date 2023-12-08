using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class FirstTest
    {
        [Fact]
        public void CollectionWithElements_First_Success()
        {
            var item = new[] { 1, 2, 3, 4 };

            Assert.Equal(1, item.First());
        }

        [Fact]
        public void EmptyCollection_First_Throws()
        {
            var item = Array.Empty<int>();

            Assert.Throws<InvalidOperationException>(() => item.First());
        }
    }
}
