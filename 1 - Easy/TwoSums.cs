namespace LeetCode._1___Easy;

public class TwoSums
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (dict.TryGetValue(diff, out int value))
            {
                return [value, i];
            }

            dict.TryAdd(nums[i], i);
        }

        return [];
    }
}
