namespace leetcode.medium;

public partial class Solution
{
    // Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    // Output: [[7,4,1],[8,5,2],[9,6,3]]

    public int[][] Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        // transpose
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // reverse each row
        for (int i = 0; i < n; i++)
        {
            Array.Reverse(matrix[i]);
        }

        return matrix;
    }
}