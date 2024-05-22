using ConsoleApp1.Models.Devices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clone
            var computer = new Computer("Linux", "DefaultComputer");
            var notebook = (Computer)computer.Clone();
            //Меняем данные у папы
            computer.System = "Windows";
            computer.Name = "WithoutProblems";
            Console.WriteLine(string.Format("Папа: Имя:{0}, Система:{1} ",computer.Name, computer.System));
            Console.WriteLine(string.Format("Сынок: Имя:{0}, Система:{1}", notebook.Name, notebook.System));
            //MyClone
            var dadwatch = new Watch(true, "Iphone", true);
            var watch = dadwatch.MyClone();
            //Меняем данные у папы
            dadwatch.Name = "Android";
            dadwatch.HaveSimCard = false;
            dadwatch.NeedAdditionalConnect = false;
            
            Console.WriteLine(string.Format("папа: Имя:{0}, Симка:{1}, Коннект: {2}  ", dadwatch.Name, dadwatch.HaveSimCard, dadwatch.NeedAdditionalConnect));
            Console.WriteLine(string.Format("Сынок: Имя:{0}, Симка:{1}, Коннект: {2} ", watch.Name, watch.HaveSimCard, watch.NeedAdditionalConnect));




            Console.WriteLine("Выводы:");
            Console.WriteLine(string.Format("Плюсы:{0}","Собственный интерфейс имеет гибкую реализацию. IClonable общедоступный интерфейс известный всем"));
            Console.WriteLine(string.Format("Минусы:{0}", "Собственный интерфейс требует дополнительного вникания и имеет дополнительные затраты на разработку"));
        }
    }
}
