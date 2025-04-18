namespace Puzzles;

public class Day4(int i) : Day(i)
{
    private const string Term = "XMAS";

    public override string Part1()
    {
        var count = 0;
        
        var rev = Term.Reverse().ToString();
        
        for (var y = 0; y < Lines.Count; y++)
        {
            for (var x = 0; x < Lines[y].Length; x++)
            {
                if (x >= Term.Length)
                {
                    var sub = Lines[y].Substring(x - Term.Length, Term.Length);
                    if (sub == Term || sub == rev)
                    {
                        count++;
                    }
                    if (Lines[y].Length - x >= Term.Length)
                    {
                        var sub2 = Lines[y].Substring(x, Term.Length);
                        if (sub2 == Term || sub2 == rev)
                        {
                            count++;
                        }
                    }
                }
            }
        }
        return "";
    }

    public override string Part2()
    {
        throw new NotImplementedException();
    }
}