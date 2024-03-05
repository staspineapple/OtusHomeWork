using System.Diagnostics;
using System.IO;
using System.Text;

namespace OtusHomework6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 пункт
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<string> paths = new List<string>() { @"D:\temp\1.txt", @"D:\temp\2.txt", @"D:\temp\3.txt" };   // путь к файлу1
            Task[] tasks = new Task[3];
            int i = 0;
            foreach (var path in paths)
            {
                tasks[i] = Task.Run(() =>
                {
                    using (FileStream fstream = File.OpenRead(path))
                    {
                        byte[] buffer = new byte[fstream.Length];
                        fstream.Read(buffer, 0, buffer.Length);
                        string textFromFile = Encoding.Default.GetString(buffer);
                        Console.WriteLine($"Кол-во пробелов в файле: {textFromFile.Count(x => x.Equals(' '))}");
                    }
                });
                i++;
            }
            
          
            Task.WaitAll(tasks);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString());
            sw.Restart();
            //2 пункт
            ReadFiles(@"D:\temp\");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds.ToString());
        }



        private static void ReadFiles(string path)
        {
            var files = Directory.GetFiles(path);


            Parallel.ForEach(files, file =>
            {
                using (FileStream fstream = File.OpenRead(file))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.Read(buffer, 0, buffer.Length);
                    string textFromFile = Encoding.Default.GetString(buffer);
                    Console.WriteLine($"Кол-во пробелов в файле: {textFromFile.Count(x => x.Equals(' '))}");

                }
            });

        }





    }
}