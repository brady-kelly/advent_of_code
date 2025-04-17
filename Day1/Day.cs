namespace Puzzles;

public abstract class Day(int dayNumber)
{
    protected string Input = null!;
    protected List<string> Lines = null!;

    public virtual void Init()
    {
        Input = File.ReadAllText(GetInputPath(dayNumber));
        Lines = File.ReadAllLines(GetInputPath(dayNumber)).ToList();
    }

    public abstract string Part1();

    public abstract string Part2();

    protected virtual List<string> SplitToStrings(string input)
    {
        return input.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).ToList();
    }

    protected string GetInputPath(int dayNumber)
    {
        return Path.Combine(Constants.InputFolder, $"day-{dayNumber}.txt");
    }
}