using System;
using System.Linq;

namespace SoftServe_IT_Academy.Linq_to_objects._Serialization
{
    internal class Aggregate
    {
        public static double EvaluateAggregate(double[] inputData, Func<double, double, double> aggregate, Func<double, int, bool> predicate) =>
            inputData.Where(predicate).Aggregate(aggregate);
    }
}
