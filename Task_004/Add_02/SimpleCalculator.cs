using System;
using System.Linq;

namespace Add_02
{
    public class SimpleCalculator
    {
        public int AddOfSomeNumbers(string s)
        {
            return s.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i))
                .Sum();
        }

    }
}    
