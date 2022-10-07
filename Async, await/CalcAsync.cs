using System;
using System.Threading.Tasks;

namespace SoftServe_IT_Academy.Async__await
{
    public class CalcAsync
    {
        public static async void PrintSeqAsync(int n)
        {
            await Task.Run(() =>
                Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }
    }

    // For compiler reasons
    internal class Calc
    {
        internal static int Seq(int n)
        {
            return 0;
        }
    }
}
