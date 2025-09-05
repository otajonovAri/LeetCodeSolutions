using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using LeetCodeConsoleApp.Benchmark_0000_1000;

// Benchmark TwoSum Problem
BenchmarkRunner.Run<TwoSumBenchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);

// Benchmark ContainsDuplicate Problem
BenchmarkRunner.Run<ContainsDuplicateBenchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);

// Benchmark Reverse Problem
BenchmarkRunner.Run<ReverseBenchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);

//Benchmark RemoveDuplicate Problem
BenchmarkRunner.Run<RemoveDuplicatesBenchmark>(
    DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator)
);