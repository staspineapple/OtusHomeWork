using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Models.Devices
{
    /// <summary>
    /// Класс Телефона
    /// </summary>
    public class Phone: Device, IMyCloneable<Phone>
    {
        public bool HaveSimCard {  get; set; }

        public Phone(bool haveSimCard, string name)
        {
            HaveSimCard = haveSimCard;
            Name = name;
        }

        public override object Clone()
        {
            return MyClone();
        }

        public Phone MyClone()
        {
            return new Phone(HaveSimCard, Name);
        }
    }
}
