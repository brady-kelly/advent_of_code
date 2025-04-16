namespace Puzzles;

public abstract class Day(int dayNumber)
{
    protected List<string> Lines = null!;

    public virtual void Init()
    {
        Lines = File.ReadAllLines(Path.Combine(Constants.InputFolder, $"day-{dayNumber}.txt.og")).ToList();
    }

    public virtual List<string> SplitToStrings(string input)
    {
        return input.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
    }
}