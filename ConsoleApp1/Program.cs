using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
    
    [MemoryDiagnoser]
    public class Benchmarks
    {
        private const int NumOfIterations = 1;

        [Benchmark]
        public int IList()
        {
            int sum = 0;
            IList<int> numbers = new List<int> { 0 };

            for (int i = 0; i < NumOfIterations; i++)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }

        [Benchmark]
        public int List()
        {
            int sum = 0;
            List<int> numbers = new List<int> { 0 };

            for (int i = 0; i < NumOfIterations; i++)
            {
                foreach (var number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}