using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                for (int i = 1; i <= 80; i += 4)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Первое задание выполнено");


                for (char x = 'c'; x <= 'j'; x++)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine("Второе задание выполнено");

                int n = 6;
                int m = 5;
                for (int i = 0; i < m; i++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        Console.Write('#');
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Третье задание выполнено");


                for (int i = 0; i <= 100; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
                Console.WriteLine("Четвертое задание выполнено");


                for (int i = 1, j = 40; i - j <= 15; i++, j--)
                {
                    Console.WriteLine(i - j);
                }
                Console.WriteLine("Пятое задание выполнено");
            }

        }
    }
}

