public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (nums[0] == target || nums[0] > target)
        {
            return 0;
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
            if (nums[i] > target && target > nums[i - 1])
            {
                return i;
            }
        }
        return nums.Length;
    }
}