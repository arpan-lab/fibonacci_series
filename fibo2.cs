using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo2
{
    internal class Program
    {
        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            else
                return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter limit: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series using Iteration:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciRecursive(i) + " ");
            }
            Console.ReadKey();
        }
    }
}
