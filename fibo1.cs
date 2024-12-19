using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Enter limit: ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("The fibonacci Series is: ");
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 3; i <= count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
            Console.ReadKey();
        }
    }
}

