public class Solution
{
    public bool IsPerfectSquare(int num)
    {
        long min = 1;
        long max = num;

        while (min <= max)
        {
            long middle = min + (max - min) / 2;
            long square = middle * middle;

            if (square > num)
                max = middle - 1;
            else if (square < num)
                min = middle + 1;
            else
                return true;
        }

        return false;
    }
}