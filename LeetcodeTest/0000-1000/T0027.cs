using LeetcodeSolution._0000_1000;

namespace LeetcodeTest._0000_1000;

public class T0027
{
    private readonly P0027 _solution = new P0027();

    [Fact]
    public void RemoveElements_Returns_CaseOne()
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;


        int length = _solution.RemoveElement(nums, val);


        Assert.Equal(2 , length);
        Assert.Contains(2, nums[..length]);
        Assert.All(nums[..length] , n => Assert.Equal(2 , n));
    }

    [Fact]
    public void RemoveElements_Returns_CaseTwo()
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 4;


        int lenght = _solution.RemoveElement(nums, val);


        Assert.Equal(3 , lenght);
        Assert.Equal(new int[]{1,2,3} , nums[..lenght]);
    }

    [Fact]
    public void RemoveElements_Returns_CaseThere()
    {
        int[] nums = { };
        int val = 1;

        int length = _solution.RemoveElement(nums, val);

        Assert.Equal(0 , length);
    }

    [Theory]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    [InlineData(new int[] { 1 }, 1, 0)]
    [InlineData(new int[] { 1 }, 2, 1)]
    public void RemoveElements_Returns_MultiplyCases(int[] nums , int val , int exp)
    {
        int length = _solution.RemoveElement(nums, val);
        Assert.Equal(exp , length);
    }
}