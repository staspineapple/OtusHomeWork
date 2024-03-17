using System.Collections.Generic;
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

            List<int> list = new List<int>();
            for (int i = 0; i < 100000000; i++)
            {
                list.Add(rnd.Next(10));
            }
            sw.Start();
            var resultSum = Sum(list);
            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения последовательного вычисления: {sw.ElapsedMilliseconds}");
            //Паралельное
            sw.Restart();
            resultSum = SumThread(list);


            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения параллельного вычисления: {sw.ElapsedMilliseconds}");
            //Паралельное c LINQ
            sw.Restart();
            resultSum = SumAsPar(list);

            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения LINQ: {sw.ElapsedMilliseconds}");

        }

        private static int Sum(List<int> list)
        {
            return list.Sum(t => t);
        }

        private static int SumAsPar(List<int> list)
        {
            return list.AsParallel().Sum();
        }

        private static int SumThread(List<int> list)
        {
            var resultSum = 0;
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
            return resultSum;
        }

    }
        
}