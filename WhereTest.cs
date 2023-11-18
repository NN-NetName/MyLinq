using MuLinq;
using System;
using Xunit;

namespace MyLinq.Tests
{
    public class WhereTest
    {
        [Fact]
        public void NotEmptyCollection_GetElementsMoreThanFive_Success()
        {
            var array = new[] { 1, 2, 3, 4, 5, 10, 20 };
            var expected = new[] {10, 20};

            var result = array.Where(o => o > 5);

            Assert.Equal(expected,result);

        }

        [Fact]
        public void NullSource_Throws()
        {
            int[] array = null;
            
            Assert.Throws<InvalidOperationException>(() => array.Where(o => o > 0));
        }

        [Fact]
        public void NotEmptyCollection_GetNonFitElements_EmptyResult()
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            var result = array.Where(o => o > 5);
            Assert.Empty(result);
        }

        [Fact]
        public void CollectionWithtupels_GetSpecificOne_Success()
        {
            var array = new (int Garde, double Salary)[]
            {
                (Grade: 5, Salary: 10),
                (Grade: 10, Salary: 2400),
            };

            var result = array.Where(o => o.Garde == 10);

            Assert.Single(result);
        }
        [Fact]
        public void CollectionWithElements_First_Success()
        {
            var array = new[] { 1, 2, 3};
            Assert.Equal(1, array.First());
            
        }
        [Fact]
        public void CollectionWithElements_First_Throws()
        {
            var array = Array.Empty<int>();
            Assert.Throws<InvalidOperationException>(() => array.First());
        }
        public void CollectionWithElements_FirstOrDefault_Success()
        {
            var array = new[] { 1, 2, 3 };

            var result = array.FirstOrDefault();

            Assert.Equal(1, result);
        }
        [Fact]
        public void NonCollectionWithElements_FirstOrDefaultWithCriteria_Success()
        {
            var array = new[] { 1, 2, 3 };

            var result = array.FirstOrDefault(array => array == 3);

            Assert.Equal(3, result);
        }
        [Fact]
        public void NonCollectionWithElements_FirstOrDefaultWithCriteria_NonMatchingElemnt_ReturnsDefault()
        {
            var array = new[] { 1, 2, 3 };

            var result = array.FirstOrDefault(array => array == 33);

            Assert.Equal(0, result);
        }
    }
}