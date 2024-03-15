public class Solution {
    public bool IsValid(string s) {
        Stack<char> exp = new Stack<char>();
        char[] start = ['{', '[', '(']; 
        char[] end = ['}', ']', ')'];

        for(int i = 0; i < s.Length; i++)
        {
            for(int j = 0; j < start.Length; j++)
            {
                if (s[i] == start[j])
                {   
                    // Console.WriteLine("Queue:");
                    // Console.WriteLine(end[j]);
                    exp.Push(end[j]);
                    break;
                }
            }
            if (exp.Count == 0)
            {
                return false;
            }

            for(int j = 0; j < end.Length; j++)
            {
                if (s[i] == end[j])
                {
                    // char el = exp.Pop();
                    // Console.WriteLine("Dequeue:");
                    // Console.WriteLine(el);
                    // Console.WriteLine(end[j]);
                    // Console.WriteLine(end[j] != el);
                    if (end[j] != exp.Pop())
                    {
                        // Console.WriteLine("we go in here :3");
                        return false;
                    }
                    break;
                }
            }
        }
        return exp.Count == 0;
    }
}


class Case {
    public string input {get; set;} = new("");
    public bool output {get; set;} = new();
}

class Program
{
    static void Main(string[] args) {
        Solution obj = new Solution();

        List<Case> cases = new List<Case> {
            new Case {input="()", output=true}, 
            new Case {input="()[]{}", output=true}, 
            new Case {input="(]", output=false},
            new Case {input="([)]", output=false}
            };

        foreach(Case i in cases)
        {
            Console.WriteLine("Expected: {0}", i.output);
            Console.WriteLine("Function: {0}", obj.IsValid(i.input));
        }
    }
}