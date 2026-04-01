using System;

namespace LeetCode.String;

public void Main(string[] args)
{
	var solution = new LargestCommonPrefix();
	Console.WriteLine(solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" })); // "fl"
}


public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = ShortestPrefix(strs);
        for (int i = 1; i < strs.Length - 1; i++)
        {
            string result = string.Empty;
            char[] pa = prefix.ToCharArray();
            char[] sa = strs[i].ToCharArray();
            for (int j = 0; j < sa.Length - 1; j++)
            {
                if (sa[j] == pa[j])
                {
                    result += pa[j];
                }
                else
                {
                    prefix = "";
                    break;
                }
            }
            prefix = result;
        }
        return prefix;
    }

    public string ShortestPrefix(string[] strs)
    {
        return strs.OrderBy(s => s.Length).FirstOrDefault();
    }
}