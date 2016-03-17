using System;
using System.Linq;
namespace Add_04
{
    public class SimpleCalculator
    {
        public int AddOfSomeNumbers(string s)
        {
            return s.Split(new[] { ',', '.', ' ', '_', '*', '&', '^', '%', '$', '#', '@', '!', '~' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(i => (int)uint.Parse(i))
                .Sum();
        }

    }
}
