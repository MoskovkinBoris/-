using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
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
            int n;
            double x, y, z = 0;
            n = Convert.ToInt32(Console.ReadLine());
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    z = z + ((Math.Pow(x, i) - Math.Pow(y, i)) / (i * (i + 2)));
                else
                    z = z - ((Math.Pow(x, i) - Math.Pow(y, i)) / (i * (i + 2)));
            }
            Console.WriteLine(z);
            //
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}
