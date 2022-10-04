using System;
using System.Threading;

namespace SoftServe_IT_Academy.Tasks._Multithreading
{
    public class MyProgram
    {
        static object lockObj = new object();

        public static void Counter(int x)
        {
            Thread FactorialThread = new Thread(new ParameterizedThreadStart(Factorial));
            FactorialThread.Start(x);

            Thread FibonacciThread = new Thread(new ParameterizedThreadStart(Fibonacci));
            FibonacciThread.Start(x);
        }

        private static void Factorial(object x)
        {
            lock (lockObj)
            {
                int res = 1;
                int number = (int)x;

                for (int i = 1; i <= number; i++)
                {
                    res *= i;
                }

                Console.WriteLine($"Factorial is: {res}");
            }
        }

        private static void Fibonacci(object x)
        {
            lock (lockObj)
            {
                int number = (int)x;
                int p = 0;
                int q = 1;

                for (int i = 0; i < number; i++)
                {
                    int temp = p;
                    p = q;
                    q = temp + q;
                }

                Console.WriteLine($"Fibbonaci number is: {p}");
            }
        }

        private static int FibonacciSeries(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            return (FibonacciSeries(n - 1) + FibonacciSeries(n - 2));
        }
    }
}
