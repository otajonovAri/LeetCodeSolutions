namespace LeetcodeSolution._0000_1000;

public class P0001
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var temp = target - nums[i];
            if (dict.TryGetValue(temp, out var value))
                return [value, i];

            dict[nums[i]] = i;
        }

        return [];
    }
}