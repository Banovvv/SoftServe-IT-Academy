using System;
using System.Threading.Tasks;

namespace SoftServe_IT_Academy.Tasks._Multithreading
{
    public class MultithreadingTask
    {
        public static void Tasks()
        {
            int[] sequence_array = new int[10];

            Task[] tasks = new Task[3]
            {
                new Task(() =>
                {
                    for(int i = 0; i < 10; i++)
                    {
                        sequence_array[i] = i*i;
                    }

                    Console.WriteLine("Calculated!");
                }),
                new Task(() =>
                {
                    for(int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(i);
                    }

                    Console.WriteLine("Bye!");
                }),
                new Task(() =>
                {
                    for(int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(sequence_array[i]);
                    }

                    Console.WriteLine("Bye!");
                })
            };

            foreach (var task in tasks)
            {
                task.Start();
                task.Wait();
            }

            Task.WaitAll(tasks);

            Console.WriteLine("Main done!");
        }
    }
}
