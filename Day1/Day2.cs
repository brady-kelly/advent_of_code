namespace Puzzles
{
    public class Day2(int dayNumber) : Day(dayNumber: dayNumber)
    {
        private readonly List<List<int>> _reports = [];

        public override void Init()
        {
            base.Init();

            foreach (var line in Lines)
            {
                var strings = SplitToStrings(line);
                var levels = strings.Select(int.Parse).ToList();
                _reports.Add(levels);
            }
        }

        public string Part1()
        {
            var safeCount = 0;
            foreach (var rep in _reports)
            {
                if (IsReportSafe(rep))
                {
                    safeCount++;
                }
            }
            return safeCount.ToString();
        }

        public string Part2()
        {
            var safeCount = 0;
            foreach (var rep in _reports)
            {
                if (IsReportSafe(rep))
                {
                    safeCount++;
                }
                else
                {
                    for(var i = 0; i < rep.Count; i++)
                    {
                        var repStart = rep[0..i];
                        var repEnd = rep[(i + 1)..^0];
                        var newRep = repStart.Concat(repEnd).ToList();
                        if (IsReportSafe(newRep))
                        {
                            safeCount++;
                            break;
                        }
                    }
                }
            }
            return safeCount.ToString();
        }

        private bool IsReportSafe(List<int> rep)
        {
            var safe = true;
            var ld = rep[0] - rep[1];
            for (var i = 1; i < rep.Count - 1; i++)
            {
                var cd = rep[i] - rep[i + 1];
                if (int.Sign(cd) != int.Sign(ld) || Math.Abs(ld) < 1 || Math.Abs(ld) > 3 || Math.Abs(cd) < 1 || Math.Abs(cd) > 3)
                {
                    safe = false;
                    break;
                }
                ld = cd;
            }
            return safe;
        }
    }
}
