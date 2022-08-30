using System.Linq;

namespace SoftServe_IT_Academy.Linq_to_objects._Serialization
{
    internal class SumOfElements
    {
        public static double EvaluateSumOfElementsOddPositions(double[] inputData) => inputData.Where((x, i) => i % 2 != 0).Sum();
    }
}
