using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftServe_IT_Academy.Linq_to_objects._Serialization
{
    internal class Product
    {
        public static int ProductWithCondition(List<int> list, Func<int, bool> condition) =>
               list.Where(condition).Count() == 0 ? 1 : list.Where(condition).Aggregate((total, next) => total * next);
    }
}
