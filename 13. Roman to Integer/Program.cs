// OLD SOLUTION (SLOW)
// public class Solution {
//     public int RomanToInt(string s) {
//         Dictionary<char, int> romannumerals = new Dictionary<char, int> (){{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
//         List<char> keylist = new List<char>(romannumerals.Keys);

//         Console.WriteLine(romannumerals['I']);
        
//         int total = 0;
//         for (int i = 0; i < s.Length; i++)
//         {
//             int mult = 1;
//             if (i + 1 != s.Length)
//             {
//                 if (keylist.FindIndex(0, keylist.Count, x => x.Equals(s[i])) < keylist.FindIndex(0, keylist.Count, x =>  x.Equals(s[i + 1])))
//                 {
//                     mult = -1;
//                 }
//             }
//             total += romannumerals[s[i]] * mult;
//         }

//         return total;
//     }
// }

public class Solution {
    readonly Dictionary<char, int> romannumerals = new Dictionary<char, int> (){{'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};
    public int RomanToInt(string s)
    {
        int result = 0;
        int prev = 0;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            int curr = romannumerals[s[i]];
            if(curr >= prev)
            {
                result += curr;
            }
            else {
                result -= curr;
            }
            prev = curr;
        }

        return result;
    }
}

class Case {
    public string input {get; set;} = new("");
    public int output {get; set;} = new();
}

class Program
{
    static void Main(string[] args) {
        Solution obj = new Solution();

        List<Case> cases = new List<Case> {
            new Case {input="III", output=3}, 
            new Case {input="LVIII", output=58}, 
            new Case {input="MCMXCIV", output=1994}};

        foreach(Case i in cases)
        {
            Console.WriteLine("Expected: {0}", i.output);
            Console.WriteLine("Function: {0}", obj.RomanToInt(i.input));
        }
    }
}