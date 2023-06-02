using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>
        (IEnumerable<T> items, T item) where T : IComparable<T>
        {
            var itemsCheck = items.ToList();
            
            foreach (object i in items)
            {
                if (i > item) itemsCheck.Remove(i);
            }

            return itemsCheck;
        }
    }
}