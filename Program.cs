using leetcode.medium;

namespace leetcode;

public static class Program
{
    public static void Main()
    {
        // var solver = new easy.Solution();
        var solver = new medium.Solution();
        // var solver = new hard.Solution();

        int[] arr = [1,2,3,4,5,6,7];

        solver.Rotate(arr, 3);

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}