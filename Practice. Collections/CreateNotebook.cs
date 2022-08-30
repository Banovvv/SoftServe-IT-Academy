using System.Collections.Generic;
using System.Linq;

namespace SoftServe_IT_Academy.Practice._Collections
{
    public class Program
    {
        public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
        {
            ILookup<string, string> lookup = phonesToNames.ToLookup(x => x.Value ?? string.Empty, x => x.Key);
            return (Lookup<string, string>)lookup;
        }
    }
}
