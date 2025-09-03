namespace LeetCodeSolution._0000_1000;

public class P0007
{
    public int Reverse(int x)
    {
        long res = 0;

        while (x != 0)
        {
            res = res * 10 + (x % 10);
            x /= 10;
        }

        return res is > int.MaxValue or < int.MinValue ? 0 : (int)res;
    }
}