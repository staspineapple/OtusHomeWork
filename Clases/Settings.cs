using OtuzHomeWork1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtuzHomeWork1.Clases
{
    internal class Settings : ISettings
    {
        /// <summary>
        /// Первое число диапазона чисел, в котором будут рандомиться числа
        /// </summary>
        internal int _firstNumberRange;
        /// <summary>
        /// Второе число диапазона чисел, в котором будут рандомиться числа
        /// </summary>
        internal int _secondNumberRange;
        /// <summary>
        /// Кол-во попыток
        /// </summary>
        internal int _countAttempts;
        public Helper _helper;
        /// <summary>
        /// Установка стандартных знаечний настроек
        /// </summary>
        /// <param name="firstNumberRange"></param>
        /// <param name="secondNumberRange"></param>
        /// <param name="countAttemts"></param>
        public Settings(int firstNumberRange = 0, int secondNumberRange = 100, int countAttemts = 10)
        {
            _firstNumberRange = firstNumberRange;
            _secondNumberRange = secondNumberRange;
            _countAttempts = countAttemts;
            _helper = new Helper();
        }

        public void SetSettings()
        {
            Console.WriteLine("Введите первое число диапазона чисел: ");
            _firstNumberRange = _helper.CheckEnteredNumber(Console.ReadLine());
            Console.WriteLine("Введите второе число диапазона чисел: ");
            _secondNumberRange = _helper.CheckEnteredNumber(Console.ReadLine()); ;
            Console.WriteLine("Введите кол-во попыток на отгадку: ");
            _countAttempts = _helper.CheckEnteredNumber(Console.ReadLine()); ;
        }


    }
}
