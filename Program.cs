using LeetCode._1___Easy;

namespace LeetCode;

class Program
{
    static void Main(string[] args)
    {
        //var twoSums = new TwoSums();
        //var result = twoSums.TwoSum([2, 7, 11, 15], 26);
        //Console.WriteLine(result);

        //var palindrome = new PalindromeNumber();
        //PalindromeNumber.IsPalindrome(-121);

        var word = Console.ReadLine();

        var romanToInteger = new RomanToInteger();

        var retorno = romanToInteger.RomanToInt(word);
        Console.WriteLine(retorno);

    }
}
