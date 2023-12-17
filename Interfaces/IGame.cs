using OtuzHomeWork1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtuzHomeWork1.Interfaces
{
    public interface IGame
    {
        /// <summary>
        /// Начало игры
        /// </summary>
        void StartGame();

        /// <summary>
        /// Конец игры
        /// </summary>
        string EndGame();
        /// <summary>
        ///  Сравнение чисел для продвижения логики игры
        /// </summary>
        /// <param name="currentDigit"></param>
        /// <param name="resultDigit"></param>
        /// <returns></returns>
        public Comparison ReturnComparison(int currentDigit, int resultDigit);
    }
}
