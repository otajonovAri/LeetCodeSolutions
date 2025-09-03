using LeetCodeSolution._0000_1000;

namespace LeetcodeTest._0000_1000;

public class T0007
{
    private readonly P0007 _solution = new P0007();

    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(1, 0)]
    [InlineData(7, 7)]
    [InlineData(-9, -9)]
    [InlineData(1534236469, 0)] // Overflow test
    [InlineData(-1563847412, 0)] // Overflow test
    [InlineData(int.MaxValue, 0)] // Edge case
    [InlineData(int.MinValue, 0)] // Edge case
    public void Reverse_Test_Cases(int x, int exp)
    {
        var result = _solution.Reverse(x);
        Assert.Equal(exp, result); 
    }
}