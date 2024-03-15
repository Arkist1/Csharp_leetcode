public class Solution {
    public int[] PlusOne(int[] digits) {
        int carry = 0;
        digits[digits.Length -1] += 1;
        
        for (int i = digits.Length -1; i >= 0; i--)
        {
            digits[i] += carry;
            if (digits[i] == 10)
            {
                digits[i] = 0;
                carry = 1;
            } 
            else
            {
                carry = 0;
                break;
            }
        }

        if (carry == 1)
        {
            int[] res = new int[] {1};
            return res.Concat(digits).ToArray();
        }

        return digits;
    }
}