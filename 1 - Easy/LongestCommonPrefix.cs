namespace LeetCode._1___Easy;

public class LongestCommonPrefix
{
    public string FindLongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);
        var s1 = strs[0];
        var s2 = strs[strs.Length - 1];
        var idx = 0;

        while (idx < s1.Length && idx < s2.Length)
        {
            if (s1[idx] == s2[idx])
            {
                idx++;
            }
            else
            {
                break;
            }
        }

        return s1.Substring(0, idx);
    }
}
