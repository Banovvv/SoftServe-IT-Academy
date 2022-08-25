using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServe_IT_Academy.Practice._Delegates__Events
{
    public static class StringExtensions
    {
        public static int WordCount(this string text) =>
               text.Split(new char[] { ' ', '.', '?', '!', '-', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
