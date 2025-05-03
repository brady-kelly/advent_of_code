namespace Puzzles;

public class Day4(int i) : Day(i)
{
    private const string Term = "XMAS";

    public override string Part1()
    {
        var count = 0;
        
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
                    var charY = col;
                    var charX = row;
                    
                    var word = new char[Term.Length];
                    word[0] = Lines[row][col];
                    
                    for (var i = 1; i < word.Length; i++)
                    {
                        charY += d[0];
                        charX += d[1];
                        if (charY >= 0 && charY < Lines[0].Length - 1 && charX >= 0 && charX < Lines.Count - 1)
                            word[i] = Lines[charY][charX];
                    }
                    var fs = string.Join("", word);
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