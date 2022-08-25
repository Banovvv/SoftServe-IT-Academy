using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe_IT_Academy.Practice._Delegates__Events
{
    public static class IListExtensions
    {
        public static List<int> IncreaseWith(this List<int> list, int x)
        {
            for (var i = 0; i < list.Count; i++)
            {
                list[i] += x;
            }

            return list;
        }
    }

    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this List<T> list) => "[" + string.Join(", ", list) + "]";
    }
}
