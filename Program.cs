using leetcode.medium;
using Microsoft.Extensions.Logging;

namespace leetcode;

public static class Program
{
    public static void Main()
    {
        // var solver = new easy.Solution();
        var solver = new medium.Solution();
        // var solver = new hard.Solution();

        var result = solver.SpiralOrder([[1,2,3,4],[5,6,7,8],[9,10,11,12],[13,14,15,16],[17,18,19,20],[21,22,23,24]]);
        
        foreach (int path in result)
        {
            Console.Write($"{path} ");
        }
    }
}