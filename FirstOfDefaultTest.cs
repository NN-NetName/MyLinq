using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinq.Tests
{
    public class FirstOfDefaultTest
    {
        [Fact]
        public void EmptyCollection_FirstOrDefault_ReturnsDefault()
        {
            var item = Array.Empty<int>();

            var result = item.FirstOrDefault();

            Assert.Equal(0, result);
        }

        [Fact]
        public void EmptyCollection_FirstOrDefault_ReturnsFirst()
        {
            var item = new[] { 1, 2, 3 };

            var result = item.FirstOrDefault();

            Assert.Equal(1, result);
        }

        [Fact]
        public void NonEmptyCollection_FirstOrDefaultWithCriteria_ReturnsMatching()
        {
            var item = new[] { 1, 2, 3 };

            var result = item.FirstOrDefault(item => item == 3);

            Assert.Equal(3, result);
        }

        [Fact]
        public void NonEmptyCollection_FirstOrDefaultWithCriteria_NoMatchingElement_ReturnsDefault()
        {
            var item = new[] { 1, 2, 3 };

            var result = item.FirstOrDefault(item => item == 33);

            Assert.Equal(0, result);
        }
    }
}
