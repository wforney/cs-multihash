namespace Multiformats.Hash.Benchmarks;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args) => new BenchmarkSwitcher(new[] {typeof(SumBenchmarks)}).Run(args);
}
