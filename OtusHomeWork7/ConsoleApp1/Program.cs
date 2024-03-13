using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("windows 10, bla bla");
            Stopwatch sw = new Stopwatch();
            Random rnd = new Random();
            var resultSum = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(rnd.Next(10));
            }
            sw.Start();
            resultSum = list.Sum(t => t);
            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения последовательного вычисления: {sw.ElapsedMilliseconds}");
             resultSum = 0;
            //Паралельное
            sw.Restart();
            int countOfThread = 5;
            List<Task> tasks = new List<Task>();
            var _lock = new object();

            for (int i = 0; i < countOfThread; i++)
            {
                var takeCount = list.Count / countOfThread;
                var skipCount = takeCount * i;

                
                tasks.Add(Task.Run(() =>
                {
                    int threadSum = 0;
                    threadSum += list.Skip(skipCount).Take(takeCount).Sum();

                    lock (_lock)
                    {
                        resultSum += threadSum;

                    }

                }));


            }

            Task.WaitAll(tasks.ToArray());


            //resultSum = ParallelEnumerable.Sum(list.AsParallel());
            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения параллельного вычисления: {sw.ElapsedMilliseconds}");
            //Паралельное c LINQ
            sw.Restart();
            resultSum = list.AsParallel().Sum();

            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения LINQ: {sw.ElapsedMilliseconds}");

        }

    }
        
}