using System;
using System.Threading.Tasks;

namespace SoftServe_IT_Academy.Async__await
{
    static partial class CalcAsync
    {
        public static async Task PrintSeqAsync(int n)
        {
            await Task.Run(() =>
                Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }

        public static async Task TaskPrintSeqAsync(int n)
        {
            await Task.Run(() =>
                Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }

        public static void PrintStatusIfChanged(this Task task, ref TaskStatus prevStatus)
        {
            if (prevStatus != task.Status)
            {
                Console.WriteLine(task.Status);
            }

            prevStatus = task.Status;
        }

        public static void TrackStatus(this Task task)
        {
            var status = TaskStatus.Created;

            while (task.Status != TaskStatus.RanToCompletion)
            {
                task.PrintStatusIfChanged(ref status);
            }

            task.PrintStatusIfChanged(ref status);
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
