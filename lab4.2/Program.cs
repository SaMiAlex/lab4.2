using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел");
            int p = 0;
            int n;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    p++;
                }
                if (n < 0)
                {
                    p--;
                }

            } while (n != 0);

            if (p > 0)
            {
                Console.WriteLine("Положительных больше");
            }
            if (p < 0)
            {
                Console.WriteLine("Отрицательных больше");
            }
            if (p == 0)
            {
                Console.WriteLine("Поровну");
            }


            Console.ReadKey();

        }
    }
}
