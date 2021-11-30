using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Повторное_решение_задания
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, k, s1; string s;
            Console.Write("Введите целое число(N>0) N=");
            s = Console.ReadLine();
            N = Convert.ToInt32(s);
            Console.WriteLine("Квадраты чисел от 1 до N:");
            s1 = 0;
            for (k = 1; k <= (2 * N - 1); k = k + 2)
            {
                s1 = s1 + k;
                Console.Write("{0}, ", s1);
            }
            Console.ReadKey();
        }
    }
}
