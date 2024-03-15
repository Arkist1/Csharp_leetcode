#nullable enable

public class Solution {
    public string LongestCommonPrefix(string[]? strs) {
        string curr = "";

        // int min = 0;
        // foreach(string i in strs)
        // {
        //     int len = i.Length;
        //     if (len == 0)
        //     {
        //         return curr;
        //     }

        //     if (len < min | min == 0)
        //     {
        //         min = len;
        //     }
        // }

        int index = 0;
        while (true)
        {
            foreach (string str in strs)
            {
                if (str.Length <= index)
                {
                    return curr;
                }

                if (strs[0][index] != str[index])
                {
                    return curr;
                }            
            }
            curr += strs[0][index];
            index++;
        }
    }
}


class Case {
    public string[]? input {get; set;}
    public string output {get; set;} = new("");
}

class Program
{
    static void Main(string[] args) {
        Solution obj = new Solution();

        List<Case> cases = new List<Case> {
            new Case {input=["flower","flow","flight"], output="fl"}, 
            new Case {input=["dog","racecar","car"], output=""}, 
            new Case {input=["","b"], output=""}
        };

        foreach(Case i in cases)
        {
            Console.WriteLine("Expected: {0}", i.output);
            Console.WriteLine("Function: {0}", obj.LongestCommonPrefix(i.input));
        }
    }
}