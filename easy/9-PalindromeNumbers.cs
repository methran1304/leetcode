namespace leetcode.easy;

public partial class Solution
{
    public int ReverseNumber(int n)
    {
        int rev = 0;
        while (n > 0)
        {
            rev = (rev * 10) + (n % 10);
            n /= 10;
        }
        return rev;
    }
    

    public bool IsPalindrome(int x)
    {
        return x == ReverseNumber(x);
    }
}