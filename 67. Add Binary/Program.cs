public class Solution {
    public string AddBinary(string a, string b) {
        int carry = 0;
        int alength = a.Length;
        int blength = b.Length;

        StringBuilder builtString = new StringBuilder();

        for (int i = 0; i < Math.Max(alength, blength); i++)
        {
            int left = 0;
            int right = 0;
            if (alength - i - 1 >= 0)
            {
                left = int.Parse(a[alength - i - 1].ToString());
            }

            if (blength - i - 1 >= 0)
            {
                right = int.Parse(b[blength - i - 1].ToString());
            }

            int calc = left + right + carry;
            carry = calc / 2;
            builtString.Insert(0, calc % 2);

        }
        if (carry != 0)
        {
            builtString.Insert(0, carry);
        }

        return builtString.ToString();
    }
}