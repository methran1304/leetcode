namespace leetcode.medium;

public partial class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var n = nums.Length;
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, n - k);
    }
}