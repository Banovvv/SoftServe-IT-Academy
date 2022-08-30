using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftServe_IT_Academy.Practice._Collections
{
    public class ProgramTwo
    {
        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        {
            ILookup<string, string> lookup = phonesToNames.ToLookup(x => x.Value ?? string.Empty, x => x.Key);
            return lookup.ToDictionary(x => x.Key.ToString(), x => x.ToList());
        }
    }
}
