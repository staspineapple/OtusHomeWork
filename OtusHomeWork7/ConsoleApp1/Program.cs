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
            resultSum = ParallelEnumerable.Sum(list.AsParallel());
            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения параллельного вычисления: {sw.ElapsedMilliseconds}");
            //Паралельное c LINQ
            sw.Restart();
            var linqSum = from n in list.AsParallel() select n; ;

            resultSum = linqSum.Sum();
            sw.Stop();
            Console.WriteLine($"Сумма:{resultSum} Время выполнения LINQ: {sw.ElapsedMilliseconds}");

        }

    }
        
}