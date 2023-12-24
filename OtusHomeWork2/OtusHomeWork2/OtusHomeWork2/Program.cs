using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text.Json;

namespace OtusHomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TestClass test = new TestClass(1,"gfhfjf", 2, "sdasd");
            var cnt = 0;
            Stopwatch sw = Stopwatch.StartNew();
            while (cnt < 1000)
            {
                string json = JsonSerializer.Serialize(test);
                //Console.WriteLine(json);
                var restore = JsonSerializer.Deserialize<TestClass>(json);
                cnt++;
            }
            sw.Stop();
            Console.WriteLine($"Прошло времени: {sw.ElapsedMilliseconds}");

            cnt = 0;
            sw.Restart();
            while (cnt < 1000)
            {
                Test();
                cnt++;
            }
                sw.Stop();
            Console.WriteLine($"Прошло времени: {sw.ElapsedMilliseconds}");
        }

        public static void Test()
        {
            var bf = new BinaryFormatter();

            var before = new TestClass(1, "gfhfjf", 2, "sdasd");

            using (var fs = new FileStream("test.txt", FileMode.Create))
            {
                bf.Serialize(fs, before);
            }

            using (var fs = new FileStream("test.txt", FileMode.Open))
            {
                var after = (TestClass)bf.Deserialize(fs);
            }
        }
    }
}