﻿using leetcode.medium;

namespace leetcode;

public static class Program
{
    public static void Main()
    {
        var easySolver = new easy.Solution();
        // var mediumSolver = new medium.Solution();
        // var hardSolver = new hard.Solution();

        var result = easySolver.IsValid("()[]{}");
        Console.WriteLine(result);
    }
}