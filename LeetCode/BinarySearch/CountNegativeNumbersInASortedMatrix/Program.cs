// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        int number = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] < 0)
                    number++;
            }
        }

        return number;
    }
}