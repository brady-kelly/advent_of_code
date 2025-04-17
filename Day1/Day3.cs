using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Puzzles;

public class Day3(int dayNumber) : Day(dayNumber)
{
    public override string Part1()
    {
        var total = MulsTotal(Input);
        return total.ToString();
    }

    public override string Part2()
    {
        //var str = "!mul(417,528)why();what()?how()don't()from()who()where() ~mul(215,18){} ])/from()*do(),)* ##select()mul(89,59):*select(805,600)*mul(709,138)-!how()$+*why(747,290)>";

        var total = 0;

        var start = 0;
        var stop = 0;
        while (stop < Input.Length)
        {
            stop = Input.IndexOf("don't()", start, StringComparison.Ordinal);
            if (stop == -1)
            {
                stop = Input.Length;
            }
            var doable = Input.Substring(start, stop - start);
            total += MulsTotal(doable);
            start = Input.IndexOf("do()", stop, StringComparison.Ordinal) + 4;
            if (start == -1)
            {
                start = Input.Length;
            }
        }

        return total.ToString();
    }

    private int MulsTotal(string text)
    {
        var total = 0;
        var rx = new Regex(@"mul\((\d+),(\d+)\)");
        var muls = rx.Matches(text);
        foreach (Match mul in muls)
        {
            total += int.Parse(mul.Groups[1].Value) * int.Parse(mul.Groups[2].Value);
        }
        return total;
    }
}