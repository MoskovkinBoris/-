using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба4
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
            int n = Convert.ToInt32(Console.ReadLine());
            string str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');
            double[] mas = new double[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToDouble(str_elem[i]);
            }
            double mx = mas[0], vtoroi = mas[1], mn = mas[0];
            for (int i = 0; i < n; i++)
            {
                if (mas[i] >= mx)
                {
                    vtoroi = mx;
                    mx = mas[i];
                }
                else
                {
                    if (mas[i] > vtoroi)
                        vtoroi = mas[i];
                }
                if (mas[i] < mn)
                    mn = mas[i];
            }
            Console.WriteLine(vtoroi);
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(mas[i]) <= 5000)
                    Console.Write("x ");
                else
                    Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            if (mn >= 0)
                Console.WriteLine("NO");
            else
                Console.WriteLine(mn);
            //
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
        }
    }
}
