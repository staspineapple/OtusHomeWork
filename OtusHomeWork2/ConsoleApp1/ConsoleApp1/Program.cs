namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.ToUniversalTime());
            Console.WriteLine((new long[0]).ToString());
        }
    }
}