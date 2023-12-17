using OtuzHomeWork1.Enums;
using OtuzHomeWork1.Interfaces;

namespace OtuzHomeWork1.Clases
{
    internal  class Helper: IHelper
    {
        public int CheckEnteredNumber(string enteredNumber)
        {
            while (!int.TryParse(enteredNumber, out int resultNumber))
            {
                Console.WriteLine("Вы ввели не число, попробуйте еще раз!");
                enteredNumber = Console.ReadLine();
            }
            return int.Parse(enteredNumber);
        }

        public void GiveHelp(Comparison comparison)
        {
            switch (comparison) 
            {
                case Comparison.More:
                    Console.WriteLine("Ваше число больше, чем загаданное мной");
                    return;
                case Comparison.Less:
                    Console.WriteLine("Ваше число меньше, чем загаданное мной");
                    return;
                case Comparison.Equally:
                    Console.WriteLine("Вы угадали число!");
                    return;
            }
        }
    }
}
