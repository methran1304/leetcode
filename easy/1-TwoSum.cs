namespace leetcode.easy;

public partial class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> d = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsValue(nums[i]))
            {
                var complementIndex = d.FirstOrDefault(d => d.Value == nums[i]).Key;
                return [complementIndex, i];
            }
            d.Add(i, target - nums[i]);
        }

        return [];
    }
}