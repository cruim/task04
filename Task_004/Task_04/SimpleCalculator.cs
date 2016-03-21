using System;
using System.Linq;

namespace Task_04
{

    public class SimpleCalculator
    {
        public int AddOfTwoNumbers(string s)
        {
                    return s.Split(new []{','}, StringSplitOptions.RemoveEmptyEntries)
                        .Take(2)
                        .Select(i =>int.Parse(i))
                        .Sum();
        }
                
    }
}    
        
