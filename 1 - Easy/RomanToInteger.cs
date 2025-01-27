namespace LeetCode._1___Easy;

public class RomanToInteger
{
    public static int RomanToInt(string s)
    {
        var total = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && GetRomanValue(s[i]) < GetRomanValue(s[i + 1]))
            {
                total += GetRomanValue(s[i + 1]) - GetRomanValue(s[i]);
                i++;
            }
            else
                total += GetRomanValue(s[i]);
        }

        return total;
    }

    private static int GetRomanValue(char romanChar)
    {
        return romanChar switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new ArgumentException("Invalid Roman numeral character")
        };
    }
}
