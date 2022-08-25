using System.Collections.Generic;

namespace SoftServe_IT_Academy.Practice._Delegates__Events
{
    public class ListProgram
    {
        public static List<int> ListWithPositive(List<int> list) => list.FindAll(x => x > 0 && x <= 10);
    }
}
