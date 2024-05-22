namespace NumberOfGoodPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int NumIdenticalPairs(int[] nums)
        {
            if (nums.Length < 1 || nums.Length > 100) return 0;

            int i = 0;
            int j = nums.Length - 1;
            int count = 0;

            while (j > 0)
            {
                if (nums[i] < 1 || nums[i] > 100)
                    break;

                if (i == j)
                {
                    i = 0;
                    j--;
                    continue;
                }

                if (nums[i] == nums[j] && i < j)
                    count++;

                i++;
            }

            return count;
        }
    }
}