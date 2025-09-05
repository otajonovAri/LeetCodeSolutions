using BenchmarkDotNet.Attributes;
using LeetCodeSolution._0000_1000;

namespace LeetCodeConsoleApp.Benchmark_0000_1000;

[MemoryDiagnoser]

public class TwoSumBenchmark
{
    private readonly P0001 _solution = new P0001();
    private int[] smallArray;
    private int[] mediumArray;
    private int[] largeArray;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = Enumerable.Range(1, 10).ToArray();
        mediumArray = Enumerable.Range(1, 10_000).ToArray();
        largeArray = Enumerable.Range(1, 1_000_000).ToArray();
    }

    [Benchmark]
    public int[] SmallArrayTest()
        => _solution.TwoSum(smallArray, 15);

    [Benchmark]
    public int[] MediumArrayTest()
        => _solution.TwoSum(mediumArray, 19_999);

    [Benchmark]
    public int[] LargeArrayTest()
        => _solution.TwoSum(largeArray, 1_999_999);
}