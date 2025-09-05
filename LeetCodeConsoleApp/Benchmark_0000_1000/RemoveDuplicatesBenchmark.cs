using BenchmarkDotNet.Attributes;
using LeetCodeSolution._0000_1000;

namespace LeetCodeConsoleApp.Benchmark_0000_1000;

[MemoryDiagnoser]
public class RemoveDuplicatesBenchmark
{
    private readonly P0026 _solution = new P0026();
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
    public void SmallArrayTest()
        => _solution.RemoveDuplicates(smallArray);

    [Benchmark]
    public void MediumArrayTest()
        => _solution.RemoveDuplicates(mediumArray);

    [Benchmark]
    public void LargeArrayTest()
        => _solution.RemoveDuplicates(largeArray);
}