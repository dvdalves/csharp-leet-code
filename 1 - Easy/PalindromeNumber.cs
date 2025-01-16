namespace LeetCode._1___Easy;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        int reverseNum = 0;
        int temp = x;

        while (temp != 0)
        {
            int digit = temp % 10;
            reverseNum = reverseNum * 10 + digit;
            temp = temp / 10;
        }
        if (x == reverseNum && x > 0)
        {
            Console.WriteLine("Yes, " + x + " is a palindrome number");
            return true;
        }
        else
        {
            Console.WriteLine("No, " + x + " is not a palindrome number");
            return false;
        }
    }
}
