using System.Text;

namespace Puzzles;

public class Day4(int i) : Day(i)
{
    private const string Term = "XMAS";

    public override string Part1()
    {
        var count = 0;
        
        int[][] deltas = new int[][]
        {
            [0, 0],
            [0, -1],
            [-1, -1],
            [-1, 0],
            [-1, +1],
            [0, +1],
            [+1, +1],
            [+1, 0],
            [+1, -1]
        };
        
        for (int row = 0; row < Lines.Count; row++)
        {
            for (int col = 0; col < Lines[0].Length; col++)
            {
                var found = new char[Term.Length];
                foreach (var d in deltas)
                {
                    var sy = col + d[0];
                    var sx = row + d[1];
                    
                    for (var i = 0; i < found.Length; i++)
                    {
                        found[i] = Lines[sy][sx];
                        sy += d[0];
                        sx += d[1];
                        if (sy >= Lines.Count || sy == 0 || sx >= Lines[0].Length || sx == 0)
                            break;
                    }
                    var fs = string.Join("", found);
                    if (fs == Term || fs == Term.Reverse().ToString())
                        count++;
                }
            }
        }
        return count.ToString();
    }
    
    public string Part1B()
    {


        return "";
    }

    public override string Part2()
    {
        throw new NotImplementedException();
    }
}