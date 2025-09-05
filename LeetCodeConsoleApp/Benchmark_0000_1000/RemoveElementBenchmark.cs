using BenchmarkDotNet.Attributes;
using LeetCodeSolution._0000_1000;

namespace LeetCodeConsoleApp.Benchmark_0000_1000;

public class RemoveElementBenchmark
{
    private readonly P0027 _solution = new P0027();
    private int[] smallArray;
    private int[] mediumArray;
    private int[] largeArray;
    private Random randomNumber = new Random();

    [GlobalSetup]
    public void Setup()
    {
        smallArray = Enumerable.Range(1, 10).ToArray();
        mediumArray = Enumerable.Range(1, 10_000).ToArray();
        largeArray = Enumerable.Range(1, 1_000_000).ToArray();
    }

    [Benchmark]
    public void SmallArrayTest()
        => _solution.RemoveElement(smallArray , randomNumber.Next(1,10));

    [Benchmark]
    public void MediumArrayTest()
        => _solution.RemoveElement(mediumArray, randomNumber.Next(1, 10_000));

    [Benchmark]
    public void LargeArrayTest()
        => _solution.RemoveElement(largeArray, randomNumber.Next(1, 1_000_000));
}