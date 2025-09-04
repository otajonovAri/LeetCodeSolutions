namespace LeetCodeSolution._0000_1000;

public class P0026
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int x = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[x] = nums[i];
                x++;
            }
        }

        return x;
    }
}