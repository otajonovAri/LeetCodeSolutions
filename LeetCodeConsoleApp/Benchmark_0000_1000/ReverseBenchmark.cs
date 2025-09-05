using BenchmarkDotNet.Attributes;
using LeetCodeSolution._0000_1000;

namespace LeetCodeConsoleApp.Benchmark_0000_1000;

public class ReverseBenchmark
{
    private readonly P0007 _solution = new P0007();

    private int[] testNumbers;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();

        testNumbers = Enumerable.Range(0, 10000)
            .Select(_ => random.Next(int.MinValue, int.MaxValue))
            .ToArray();
    }


    [Benchmark]
    public void ReverseMany()
    {
        foreach (var item in testNumbers)
            _solution.Reverse(item);
    }
}