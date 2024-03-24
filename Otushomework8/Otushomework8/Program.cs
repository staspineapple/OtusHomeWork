namespace Otushomework8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "коротка", "самая длинная строчка", "шорт", "не длинная" };

            FindmaxString(strings);

             var searcher = new Searcher();
            searcher.FileFound += FileFound;
            searcher.Search(@"D:\temp");
        }

        private static void FileFound(object? sender, FileArgs e)
        {
            Console.WriteLine("Найден файл: " + e.FileName);
        }

        private static void FindmaxString(List<string> strings)
        {
            var longest = strings.GetMax(s => s.Length);
            Console.WriteLine("Самая длинная строка: " + longest);
        }
    }
}