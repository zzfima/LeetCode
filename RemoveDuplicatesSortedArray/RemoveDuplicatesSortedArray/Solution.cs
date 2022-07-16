namespace RemoveDuplicatesSortedArray
{
    public static class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int count = 1;
            if (nums.Length == 1)
                return count;

            foreach (var num in nums)
            {
                if (nums[count - 1] < num)
                {
                    nums[count] = num;
                    count++;
                }

            }

            return count;
        }
    }
}