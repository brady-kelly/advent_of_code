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
                var charY = col;
                var charX = row;
                var word = new char[Term.Length];
                foreach (var d in deltas)
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        charY += d[0];
                        charX += d[1];
                        if (charY >= 0 && charY < Lines[0].Length && charX >= 0 && charX < Lines.Count)
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