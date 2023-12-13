public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = new int[nums.Length];
        int count = 0;

        while (count < nums.Length)
        {
            int innerCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == i)
                    continue;
                if (nums[count] > nums[i])
                    innerCount++;
            }

            result[count] = innerCount;
            count++;
        }

        return result;
    }
}