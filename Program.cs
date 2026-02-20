using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
using leetcode.medium;

namespace leetcode;

public static class Program
{
    public static void Main()
    {
        // var solver = new easy.Solution();
        var solver = new medium.Solution();
        // var solver = new hard.Solution();

        IList<IList<int>> result = solver.Subsets([1, 2, 3]);

        foreach (var subset in result)
        {
            Console.Write("[ ");
            foreach (var element in subset)
            {
                Console.Write($"{element} ");
            }
            Console.Write("], ");
        }

        Console.Write("\n");
    }
}