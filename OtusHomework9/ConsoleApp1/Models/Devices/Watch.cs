using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Models.Devices
{
    /// <summary>
    /// Класс Часов
    /// </summary>
    public class Watch: Phone, IMyCloneable<Watch>
    {
        public bool NeedAdditionalConnect { get; set; }

        public Watch(bool haveSimCard, string name, bool needAdditionalConnect) : base(haveSimCard, name)
        {
            NeedAdditionalConnect = needAdditionalConnect;
            Name = name;
            HaveSimCard = haveSimCard;
        }

        public override object Clone()
        {
            return MyClone();
        }

        public  Watch MyClone()
        {
            return new Watch(NeedAdditionalConnect, Name, HaveSimCard);
        }
    }
}
