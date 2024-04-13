public int MissingNumber(int[] nums)
{
    if (nums.Length < 1 || nums.Length > 10000)
        return 0;

    for (var i = 0; i < nums.Length + 1; i++)
    {
        if (!nums.Contains(i))
            return i;
    }

    return 0;
}