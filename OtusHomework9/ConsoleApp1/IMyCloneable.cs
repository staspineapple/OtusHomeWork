using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Собственный интерфейс для клонирования
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMyCloneable<T>
    {
        T MyClone();
    }
}
