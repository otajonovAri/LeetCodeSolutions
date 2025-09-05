using BenchmarkDotNet.Attributes;
using LeetCodeSolution._0000_1000;

namespace LeetCodeConsoleApp.Benchmark_0000_1000;

[MemoryDiagnoser]
public class ContainsDuplicateBenchmark
{
    private readonly P0217 _solution = new P0217();
    private int[] smallArray;
    private int[] largeArray;

    [GlobalSetup]
    public void Setup()
    {
        smallArray = new int[] { 1, 2, 3, 1 };
        largeArray = Enumerable.Range(0, 1000000).Concat(new int[] { 999999 }).ToArray();
    }

    [Benchmark]
    public bool SmallArrayTest() => _solution.ContainsDuplicate(smallArray);

    [Benchmark]
    public bool LargeArrayTest() => _solution.ContainsDuplicate(largeArray);
}