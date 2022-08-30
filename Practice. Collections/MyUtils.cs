using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftServe_IT_Academy.Practice._Collections
{
    public class MyUtils
    {
        public static bool ListDictionaryCompare(List<string> words, Dictionary<string, string> dictionary)
        {
            if (words.Equals(null) && dictionary.Equals(null))
            {
                return false;
            }
            else
            {
                return words.All(x => dictionary.Values.Distinct().Contains(x)) && dictionary.Values.All(y => words.Distinct().Contains(y));
            }
        }
    }
}
