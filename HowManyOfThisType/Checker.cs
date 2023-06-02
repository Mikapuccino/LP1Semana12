using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfThisType<T>(IEnumerable<object> items)
        {
            int count = 0;
            
            foreach (object i in items)
            {
                if (i is T) count++;
            }
            return count;
        }
    }
}