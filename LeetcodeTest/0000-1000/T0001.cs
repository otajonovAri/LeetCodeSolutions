using LeetCodeSolution._0000_1000;

namespace LeetcodeTest._0000_1000;

public class T0001
{
    private readonly P0001 _solution = new P0001();

    [Fact]
    public void TwoSum_Returns_CaseOne()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;


        var result = _solution.TwoSum(nums, target);


        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_ReturnsEmptyArray()
    {
        int[] nums = { 1, 2, 3 };
        int target = 0;

        var result = _solution.TwoSum(nums, target);

        Assert.Empty(result);
    }

    [Fact]
    public void TwoSum_ReturnsArray_LengthZeros()
    {
        int[] nums = null!;
        int target = 10;

        
        var result = _solution.TwoSum(nums, target);

        Assert.Empty(result);
    }
}