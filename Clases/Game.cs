using OtuzHomeWork1.Enums;
using OtuzHomeWork1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtuzHomeWork1.Clases
{
    internal class Game : IGame
    {
        private Settings _settings;
        private Helper _helper;
        private Randomizer _randomizer;
        public Game()
        {
            _settings = new Settings();
            _helper = new Helper();
            _randomizer = new Randomizer(_settings);
        }
        public void StartGame()
        {
            Console.WriteLine("Нажмите +, если хотите сменить стандартные настройки игры, другую клавишу, если хотите играть)");
            if (Console.ReadKey().Key == ConsoleKey.Add)
                _settings.SetSettings();
            var randomDigit = _randomizer.CreateRandom();
            int currentDigit;
            var count = 0;
            while (count<_settings._countAttempts)
            {
                currentDigit = _helper.CheckEnteredNumber(Console.ReadLine());
                _helper.GiveHelp(ReturnComparison(currentDigit, randomDigit));
                if (currentDigit == randomDigit)
                    return;
                count++;
            }
            Console.WriteLine("К сожалению вы не смогли угадать за лимит подсказок :(");
        }

        public Comparison ReturnComparison(int currentDigit, int resultDigit)
        {
            if (currentDigit > resultDigit)
                return Comparison.More;
            if (currentDigit < resultDigit)
                return Comparison.Less;
            return Comparison.Equally;
        }

        public string EndGame()
        {
            return "Победа";
        }

    }
}
