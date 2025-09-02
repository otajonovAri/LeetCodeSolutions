namespace LeetcodeSolution._0000_1000;

public class P0027
{
    public int RemoveElement(int[] nums, int val)
    {
        var index = 0;

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != val)
                nums[index++] = nums[i];

        return index;
    }
}