using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, s, k;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());
            double s2 = c * c - e * e;
            if (s2 == 0)
                Console.WriteLine("Выражение s = ERROR");
            else
            {
                s = a * a / s2;
                Console.Write("выражение s = ");
                Console.WriteLine(string.Format("{0:0.0}", s));
            }

            double k1 = a - c * c, k2 = c * c - d * d * d;
            if ((k1 < 0) || (k2 <= 0))
                Console.WriteLine("Выражение k = ERROR");
            else
            {
                k = Math.Sqrt(k1) / Math.Sqrt(k2);
                Console.Write("выражение k = ");
                Console.WriteLine(string.Format("{0:0.0}", k));
            }
            Console.ReadKey();
        }
    }
}
