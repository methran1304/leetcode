namespace leetcode.medium;

public partial class Solution
{
    // Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    // Output: [1,2,3,6,9,8,7,4,5]

    public void WalkBorders(int[][] matrix, int startRow, int startCol, int endRow, int endCol, ref List<int> path)
    {
        int currRow = startRow, currCol = startCol;

        if (startRow > endRow || startCol > endCol)
        {
            return;
        }

        // base - 1x1 case
        if (startRow == endRow && startCol == endCol)
        {
            path.Add(matrix[startRow][startCol]);
            return;
        }

        // (inner matrix is not NxN)
        // base case - column case (go right)
        if (endRow - startRow == 0)
        {
            Console.WriteLine("go right");
            while (currCol <= endCol)
            {
                path.Add(matrix[currRow][currCol]);
                currCol++;
            }
            return;
        }
        // base case  - row case (go down)
        if (endCol - startCol == 0)
        {
            Console.WriteLine("go down!");
            while (currRow <= endRow)
            {
                path.Add(matrix[currRow][currCol]);
                currRow++;
            }
            return;
        }

        // go right, down, left, up

        // RIGHT
        while (currCol < endCol)
        {
            path.Add(matrix[currRow][currCol]);
            currCol++;
        }


        // DOWN
        while (currRow < endRow)
        {
            path.Add(matrix[currRow][currCol]);
            currRow++;
        }


        // LEFT
        while (currCol > startCol)
        {
            path.Add(matrix[currRow][currCol]);
            currCol--;
        }


        // UP
        while (currRow > startRow)
        {
            path.Add(matrix[currRow][currCol]);
            currRow--;
        }

        WalkBorders(matrix, startRow + 1, startCol + 1, endRow - 1, endCol - 1, ref path);
    }

    public IList<int> SpiralOrder(int[][] matrix)
    {
        // cover first boundary elements
        List<int> path = new();

        int startRow, startCol, endRow, endCol;
        startRow = startCol = 0;
        endRow = matrix.Length - 1;
        endCol = matrix[0].Length - 1;

        // recursively walk the layers of borders
        WalkBorders(matrix, startRow, startCol, endRow, endCol, ref path);

        return path;
    }
}