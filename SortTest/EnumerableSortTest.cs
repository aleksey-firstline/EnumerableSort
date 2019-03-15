using FluentAssertions;
using NUnit.Framework;
using Sort;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        private byte[] source;

        [SetUp]
        public void Setup()
        {
            source = new byte[] { 1, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 };
        }

        [Test]
        public void SortWithIf_IsOrdered()
        {
            var sort = new EnumerableSort();
            var result = sort.SortWithIf(source);

            result.Should().NotBeNull();
            result.Should().BeInAscendingOrder(x => x);
        }

        [Test]
        public void SortWithSum_IsOrdered()
        {
            var sort = new EnumerableSort();
            var result = sort.SortWithSum(source);

            result.Should().NotBeNull();
            result.Should().BeInAscendingOrder(x => x);
        }

        [Test]
        public void SortWithSumForeach_IsOrdered()
        {
            var sort = new EnumerableSort();
            var result = sort.SortWithSumForeach(source);

            result.Should().NotBeNull();
            result.Should().BeInAscendingOrder(x => x);
        }

        [Test]
        public void SortWithOneFor_IsOrdered()
        {
            var sort = new EnumerableSort();
            var result = sort.SortWithOneFor(source);

            result.Should().NotBeNull();
            result.Should().BeInAscendingOrder(x => x);
        }

        [Test]
        public void SortWithParallel_IsOrdered()
        {
            var sort = new EnumerableSort();
            var result = sort.SortWithParallel(source);

            result.Should().NotBeNull();
            result.Should().BeInAscendingOrder(x => x);
        }
    }
}