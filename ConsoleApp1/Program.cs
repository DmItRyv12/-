using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0, e = 1;
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            while (e <= n * 2)
            {
                s += e;
                Console.WriteLine(s.ToString());
                e += 2;
            }
            Console.ReadKey();
        }
    }
}
