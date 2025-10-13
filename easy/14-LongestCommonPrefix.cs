namespace leetcode.easy;

public partial class Solution
{
    // Input: strs = ["flower","flow","flight"]
    // Output: "fl"
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1) return strs[0];
        string currentPrefix = "";
        int currentPos = 0;

        while (currentPos < strs[0].Length)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                if (currentPos >= strs[i].Length) return currentPrefix;
                if (strs[i][currentPos] != strs[0][currentPos]) return currentPrefix;
            }
            currentPrefix += strs[0][currentPos];
            currentPos++;
        }

        return currentPrefix;
    }
}