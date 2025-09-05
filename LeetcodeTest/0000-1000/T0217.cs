using LeetCodeSolution._0000_1000;

namespace LeetcodeTest._0000_1000;

public class T0217
{
    private readonly P0217 _solution = new P0217();
    [Fact]
    public void ContainsDuplicate_Returns_CaseOne()
    {
        int[] nums = { 1, 2, 3, 1 };

        var result = _solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Fact]
    public void ContainsDuplicate_Returns_CaseTwo()
    {
        int[] nums = { 1, 2, 3, 4 };

        var result = _solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Fact]
    public void ContainsDuplicate_Returns_CaseThere()
    {
        int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

        var result = _solution.ContainsDuplicate(nums);

        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { } , false)]
    [InlineData(new int[] { 10, 10, 10 } , true)]
    public void ContainsDuplicate_All_CaseThere(int[] nums , bool exp)
    {
        var result = _solution.ContainsDuplicate(nums);
        Assert.Equal(exp , result);
    }
}