using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    public class Sorts
    {
        IEnumerable<byte> source = new byte[] { 1, 0, 1, 0, 1, 0, 0, 0, 0 };

        [Benchmark]
        public void F()
        {
            SortWithIf(source);
        }

        public IEnumerable<byte> SortWithIf(IEnumerable<byte> array)
        {
            int d = 0;
            int s = 0;
            using (IEnumerator<byte> enumerator = array.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    if (enumerator.Current == 0)
                        d++;
                    else
                        s++;
                }
            }

            for (int i = 0; i < d; i++)
                yield return 0;

            for (int i = 0; i < s; i++)
                yield return 1;
        }
    }

    [TestFixture]
    public class SortUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            BenchmarkRunner.Run<Sorts>();
        }
    }
}