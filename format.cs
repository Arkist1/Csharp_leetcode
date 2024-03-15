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