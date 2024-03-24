using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otushomework8
{
    internal class Searcher
    {
        public event EventHandler<FileArgs> FileFound;
        public void Search(string directory, bool cancel = false)
        {
            foreach (var file in Directory.GetFiles(directory))
            {
                var args = new FileArgs(file);
                OnFileFound(args);
                if (cancel)
                {
                    Console.WriteLine("Галя, у нас отмена");
                    break;
                }
            }
        }
        public void OnFileFound(FileArgs args)
        {
            FileFound?.Invoke(this, args);
        }
        
    }
}
