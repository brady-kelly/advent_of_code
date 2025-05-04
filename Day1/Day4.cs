namespace Puzzles;

public class Day4(int i) : Day(i)
{
    private const string Term = "XMAS";

    public override string Part1()
    {
        var count = 0;
        
        List<(int x, int y)> deltas =
        [
            (-1, 0),
            (-1, -1),
            (0, -1),
            (1, 1),
            (1, 0),
            (1, -1),
            (0, -1),
            (-1, -1)
        ];
        
        for (int row = 0; row < Lines.Count; row++)
        {
            for (int col = 0; col < Lines[0].Length; col++)
            {
                foreach (var d in deltas)
                {
                    var visitX = col;
                    var visitY = row;
                    
                    var word = new char[Term.Length];
                    word[0] = Lines[row][col];
                    
                    for (var i = 1; i < word.Length; i++)
                    {
                        visitX += d.x;
                        visitY += d.y;

                        if (visitY >= 0 && visitY >= row && visitY < Lines.Count && visitX >= 0 && visitX <= col  && visitX < Lines[row].Length)
                            word[i] = Lines[visitY][visitX];
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