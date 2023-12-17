using OtuzHomeWork1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtuzHomeWork1.Interfaces
{
    internal interface IHelper
    {
        /// <summary>
        /// Подсказка пользователю, что он ввел слово, а не цифру
        /// </summary>
        /// <param name="enteredNumber"></param>
        /// <returns></returns>
        public int CheckEnteredNumber(string enteredNumber);
        /// <summary>
        /// Подсказка пользователю, в какую сторону ему надо гадать число
        /// </summary>
        /// <param name="comparison"></param>
        public void GiveHelp(Comparison comparison);
    }
}
