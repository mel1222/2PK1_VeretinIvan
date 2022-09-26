using System;
using System.Security.Principal;

namespace pz_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Введите натуральное число не меньше двух: ");
            a = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            while (a % i != 0)
            {
                i++;
            }
            Console.WriteLine(i);
            Console.ReadKey();

        }
    }
}