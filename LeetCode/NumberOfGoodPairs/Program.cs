namespace NumberOfGoodPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 1, 1, 3 };
            var result = NumIdenticalPairs(nums);
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (var x in nums)
            {
                if (dictionary.ContainsKey(x))
                    count += dictionary[x]++;
                else
                    dictionary[x] = 1;
            }

            return count;
        }
    }
}