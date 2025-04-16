namespace Day1
{
    public class Day1
    {
        private List<int> left = [];
        private List<int> right = [];

        public void Init(string filePath)
        {
            left.Clear();
            right.Clear();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var nums = line.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
                left.Add(int.Parse(nums[0]));
                right.Add(int.Parse(nums[1]));
            }
        }

        public string Part1()
        {
            left.Sort();
            right.Sort();

            int tote = 0;
            for (int i = 0; i < left.Count; i++)
            {
                tote += Math.Abs(left[i] - right[i]);
            }

            return tote.ToString();
        }

        public string Part2()
        {
            left.Sort();
            right.Sort();

            int tote = 0;
            foreach (var num in left)
            {
                tote += right.Where(x => x == num).Sum();
            }

            return tote.ToString();
        }
    }
}
