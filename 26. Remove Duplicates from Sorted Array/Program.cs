public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int last = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[last])
            {
                last++;
                nums[last] = nums[i];
            }
        }
        return last;
    }
}

class Case {
    public int[] input {get; set;}
    public int[] output {get; set;}
}

class Program
{
    static void Main(string[] args) {
        Solution obj = new Solution();

        List<Case> cases = new List<Case> {
            new Case {input=[1,1,2], output=[1,2]}, 
            new Case {input=[0,0,1,1,1,2,2,3,3,4], output=[0, 1, 2, 3, 4]}, 
            };

        foreach(Case i in cases)
        {
            Console.WriteLine("Case: {0}", "[" + string.Join(", ", i.input) + "]");
            Console.WriteLine("Expected: {0}", "[" + string.Join(", ",i.output) + "]");
            obj.RemoveDuplicates(i.input);
            Console.WriteLine("Function: {0}",  "[" + string.Join(", ",i.input) + "]");
        }
    }
}