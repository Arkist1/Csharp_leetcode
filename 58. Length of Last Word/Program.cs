public class Solution {
    public int LengthOfLastWord(string s) {
        int total = 0;
        bool start = false;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if(s[i] == ' ')
            {        
                if (start)
                {
                    return total;
                }
            }
            else
            {
                total++;
                start = true;
            }
        }
        return total;
    }
}