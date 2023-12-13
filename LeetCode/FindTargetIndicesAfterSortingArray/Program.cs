public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        Array.Sort(nums);

        var result = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
                result.Add(i);
        }

        if (result.Count > 0)
            return result;

        return new List<int>();
    }
}