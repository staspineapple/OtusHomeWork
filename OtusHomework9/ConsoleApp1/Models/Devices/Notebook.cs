using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Devices
{
    /// <summary>
    /// Класс ноутбука
    /// </summary>
    internal class Notebook : Computer, IMyCloneable<Notebook>
    {
        public bool IsPortative {  get; set; }
        public Notebook(string system, string name, bool isPortative): base ( system,  name)
        {
            System = system;
            Name = name;
            IsPortative = isPortative;
        }

        public override object Clone()
        {
            return MyClone();
        }

        public Notebook MyClone()
        {
            return new Notebook(System, Name, IsPortative);
        }
    }
}
