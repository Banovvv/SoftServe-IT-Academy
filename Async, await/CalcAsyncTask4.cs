using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftServe_IT_Academy.Async__await
{
    internal class CalcAsyncTask4
    {
        partial class CalcAsync
        {
            public async static IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    yield return (i, await Task.Run(() => Calc.Seq(i)));
                }
            }

            public async static void PrintStream(IAsyncEnumerable<(int, int)> tuple)
            {
                await foreach (var t in tuple)
                {
                    Console.WriteLine($"Seq[{t.Item1}] = {t.Item2}");
                }
            }
        }
    }
}
