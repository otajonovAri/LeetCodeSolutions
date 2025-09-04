using LeetCodeSolution._0000_1000;

namespace LeetcodeTest._0000_1000;

public class T0026
{
    private readonly P0026 _solution = new P0026();

    [Fact]
    public void RemoveDuplicates_Returns_CaseOne()
    {
        int[] nums = { 1, 1, 2 };

        var res = _solution.RemoveDuplicates(nums);

        Assert.Equal(1 , res);
    }

    [Fact]
    public void RemoveDuplicates_Returns_CaseTwo()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        var res = _solution.RemoveDuplicates(nums);


        Assert.Equal(4 , res);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 3, 21 } , 0)]
    [InlineData(new int[] { 1, 1, 1, 1, 1, 1 } , 5)]
    [InlineData(new int[] { } , 0)]
    public void RemoveDuplicates_Returns_MultiplyCases(int[] nums , int exp)
    {
        var result = _solution.RemoveDuplicates(nums);
        Assert.Equal(exp , result);
    }
}