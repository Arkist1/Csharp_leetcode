public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int last = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if(nums[i] == val)
            {
                Console.WriteLine(last);
                nums[i] = nums[last];
                last--;
            }
        }

        Console.WriteLine(string.Join(",", nums));
        return last -1;
    }
}
