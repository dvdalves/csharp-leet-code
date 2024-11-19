namespace LeetCode._1___Easy;

public class TwoSums
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement))
            {
                return new int[] { dic[complement], i };
            }
            else
            {
                dic[nums[i]] = i;
            }
        }

        return null!;
    }
}