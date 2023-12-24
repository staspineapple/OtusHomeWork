using OtuzHomeWork1.Clases;

namespace OtuzHomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (true)
            {
                game.StartGame();
                Console.WriteLine("Нажмите + чтобы продолжить играть или другую клавишу для завершения игры");
                if (Console.ReadKey().Key!=ConsoleKey.Add)
                {
                    Console.WriteLine("Спасибо, что поиграли!");
                    return;
                }
            }
        }
    }
}