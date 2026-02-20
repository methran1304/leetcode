namespace leetcode.medium;

public partial class Solution
{
    public void SubsetsRecursive(int[] nums, int curPos, IList<IList<int>> mem)
    {
        if (curPos >= nums.Length)
        {
            return;
        }

        IList<IList<int>> newSubsets = [];

        // add current element to all the subsets
        foreach (var subset in mem)
        {
            List<int> copy = new(subset);
            copy.Add(nums[curPos]);
            newSubsets.Add(copy);
        }

        foreach (var subset in newSubsets)
        {
            mem.Add(subset);
        }

        SubsetsRecursive(nums, curPos + 1, mem);
    }

    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> mem = [[]];
        SubsetsRecursive(nums, 0, mem);
        return mem;
    }
}