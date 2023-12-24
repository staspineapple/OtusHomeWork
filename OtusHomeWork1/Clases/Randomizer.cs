using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtuzHomeWork1.Clases
{
    internal class Randomizer
    {
        private Settings _settings;
        public Randomizer(Settings settings)
        { 
            _settings = settings;
        }
        public int CreateRandom() 
        { 
            Random rnd = new Random();
            return rnd.Next(_settings._firstNumberRange, _settings._secondNumberRange);
        }
    }
}
