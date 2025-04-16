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
                //Console.WriteLine(string.Join(' ', rep.Select(r => r.ToString())));

                var safe = true;
                var ld = rep[0] - rep[1];
                if (Math.Abs(ld) < 1 || Math.Abs(ld) > 3)
                {
                    continue;
                }

                for (var i = 1; i < rep.Count - 1; i++)
                {
                    var cd = rep[i] - rep[i + 1];
                    if (int.Sign(cd) != int.Sign(ld) || Math.Abs(cd) < 1 || Math.Abs(cd) > 3)
                    {
                        safe = false;
                        break;
                    }
                    ld = cd;
                }
                if (safe)
                    safeCount++;
            }
            return safeCount.ToString();
        }
    }
}
