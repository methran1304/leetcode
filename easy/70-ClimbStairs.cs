namespace leetcode.easy;

public partial class Solution
{
    private int ClimbStairsMemo(int n, Dictionary<int, int> memo)
    {
        if (n < 0) return 0;
        if (n == 0) return 1;

        if (!memo.ContainsKey(n))
            memo[n] = ClimbStairsMemo(n - 1, memo) + ClimbStairsMemo(n - 2, memo);

        return memo[n];
    }
    public int ClimbStairs(int n)
    {
        return ClimbStairsMemo(n, []);
    }
}