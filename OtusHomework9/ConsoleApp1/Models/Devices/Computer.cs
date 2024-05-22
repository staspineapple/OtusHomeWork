using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models.Devices
{
    /// <summary>
    /// Класс обычного компьютера
    /// </summary>
    public class Computer: Device, IMyCloneable<Computer>
    {
        public string System {  get; set; }

        public Computer(string system,string name)
        {
            System = system;
            Name = name;
        }

        public override object Clone()
        {
            return MyClone();
        }

        public Computer MyClone()
        {
            return new Computer(System, Name);
        }

    }
}
