using System;
using System.Linq;

namespace Add_03
{
    public class SimpleCalculator
    {
        public int AddOfSomeNumbers(string s)
        {
            return s.Split(new[] { ',', '.', ' ', '_', '*', '&', '^', '%', '$', '#', '@', '!', '~' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i))
                .Sum();
        }

    }
}
