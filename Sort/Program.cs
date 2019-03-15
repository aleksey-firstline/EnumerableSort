using BenchmarkDotNet.Running;
using System;

namespace Sort
{

    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<EnumerableSort>();
            Console.ReadLine();
        }
    }
}
