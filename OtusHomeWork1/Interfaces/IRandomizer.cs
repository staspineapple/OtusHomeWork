using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtuzHomeWork1.Interfaces
{
    internal interface IRandomizer
    {
        /// <summary>
        /// Создание рандомного числа в зависимости от настроек
        /// </summary>
        /// <returns></returns>
        public int CreateRandom();
    }
}
