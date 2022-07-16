namespace RemoveElement
{
    public static class Solution
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            if (nums.Length == 1)
                return nums[0] == val ? 0 : 1;

            int tail = nums.Length - 1;
            for (int i = 0; i <= tail; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[tail];
                    tail--;
                    i--;
                }
                else
                    count++;
            }

            return count;
        }
    }
}