
namespace Leetcode;
public class ValidPalindrome
{
    public static void Main(string[] args)
    {
        var solution = new ValidPalindrome();
        Console.WriteLine(solution.IsPalindrome("1210")); // True
        Console.WriteLine(solution.IsPalindrome("hello"));   // False
        Console.WriteLine(solution.IsPalindrome("abba"));    // True
    }

    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}