using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftServe_IT_Academy.Linq_to_objects._Serialization
{
    internal class Word
    {
        public static string GetWord(string input, string seed)
        {
            string longestWord = input.Split(' ').Aggregate(seed, (longest, next) => next.Length > longest.Length ? next : longest, inp => inp.ToLower());

            return longestWord.Contains('a') ? longestWord.Substring(longestWord.IndexOf('a')) : "";
        }
    }
}
