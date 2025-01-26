namespace LeetCode._1___Easy;

public class TwoSums
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.TryGetValue(complement, out int value))
                return [value, i];
            else
                dic[nums[i]] = i;
        }

        return null!;
    }
}