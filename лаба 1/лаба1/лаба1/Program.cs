using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЛАБОРАТОРНАЯ РАБОТА 1. РАЗРАБОТКА КОНСОЛЬНОГО ПРИЛОЖЕНИЯ");
            Console.WriteLine("Московкин Борис Кириллович");
            Console.WriteLine("Информационые системы и технологии, ИНС-б-0-19-1");
            Console.WriteLine("14.07.01");
            Console.WriteLine("город Ставрополь");
            Console.WriteLine("Любимый предмет в школе: Физическая культура");
            Console.WriteLine("Занимаюсь видео и фото съемкой");
            double r, x, y, z;
            x = 1.5;
            y = 2.5;
            z = 1.05;
            r = 2 * x + 2 * y - 4 * x * y + z;
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
