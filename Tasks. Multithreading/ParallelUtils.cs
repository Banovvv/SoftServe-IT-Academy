using System;
using System.Threading;

namespace SoftServe_IT_Academy.Tasks._Multithreading
{
    public class ParallelUtils<T, TR>
    {
        private T operand1;
        private T operand2;
        private Func<T, T, TR> func;

        public ParallelUtils(Func<T, T, TR> func, T operand1, T operand2)
        {
            this.func = func;
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public TR Result { get; set; }

        public void StartEvaluation()
        {
            Thread thread = new Thread(Evaluate);
            thread.Start();
        }

        public void Evaluate() => Result = func(operand1, operand2);
    }
}
