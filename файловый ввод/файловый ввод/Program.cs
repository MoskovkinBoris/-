using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace файловый_ввод
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            //
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

            //
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}
