using System.Text;

namespace Puzzles;

public class Day4(int i) : Day(i)
{
    private const string Term = "MASXF";

    public override string Part1()
    {
        var count = 0;
        var sb = new StringBuilder();
        
        int[][] deltas = new int[][]
        {
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
                foreach (var d in deltas)
                {
                    
                }


                
                // for (var i = col; i >= 0 && sb.Length <= Term.Length; i--)
                //     sb.Append(Lines[row][i]);
                // if (sb.ToString() == Term || sb.ToString() == Term.Reverse().ToString())
                //     count++;
                // sb.Clear();
                //
                // for(var i = col; i < Lines[0].Length && sb.Length <= Term.Length; i++)
                //     sb.Append(Lines[row][i]);
                // if (sb.ToString() == Term || sb.ToString() == Term.Reverse().ToString())
                //     count++;
                // sb.Clear();
                
                // for(int dx = col, dy = row; col - dx >= 0 && row - dy >= 0 && sb.Length <= Term.Length; dx++, dy++)
                //     sb.Append(Lines[row + dy][dx]);
            }
        }
        
        
        
        return "";
    }

    private bool IsValidCell(int row, int col, int dy, int dx)
    {
        return col 
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