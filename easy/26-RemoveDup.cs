namespace leetcode.easy;

public partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var currentElement = nums[i];
            var j = i + 1;
            while (j < nums.Length && nums[j] == currentElement)
            {
                j++;
            }
            if (j < nums.Length && j != i + 1)
            {
                nums[i + 1] = nums[j];
            }
        }

        foreach (int n in nums)
        {
            Console.WriteLine(n);
        }

        return 1;
    }
}