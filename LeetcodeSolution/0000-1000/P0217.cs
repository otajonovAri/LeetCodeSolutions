namespace LeetCodeSolution._0000_1000;

public class P0217
{
    public bool ContainsDuplicate(int[] nums)
        => nums.Distinct().ToArray().Length != nums.Length;
}