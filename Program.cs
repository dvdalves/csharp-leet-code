using LeetCode._1___Easy;

namespace LeetCode;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1 - Two Sums");
        Console.WriteLine("2 - Palindrome Number");
        Console.WriteLine("3 - Roman to Integer");

        if (int.TryParse(Console.ReadLine(), out int option))
        {
            switch (option)
            {
                case 1:
                    Console.Clear();
                    // Two Sums
                    var result = TwoSums.TwoSum([2, 7, 11, 15], 26);
                    Console.WriteLine(string.Join(", ", result));
                    break;
                case 2:
                    // Palindrome Number
                    var palindrome = new PalindromeNumber();
                    PalindromeNumber.IsPalindrome(-121);
                    break;
                case 3:
                    // Roman to Integer
                    var word = Console.ReadLine();

                    var romanToInteger = new RomanToInteger();

                    var retorno = romanToInteger.RomanToInt(word);
                    Console.WriteLine(retorno);
                    break;

                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
