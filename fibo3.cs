using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibo3
{
    internal class Program
    {
        static int FibonacciDP(int n)
        {
            int[] fib = new int[n + 1]; 
            fib[0] = 0;  
            fib[1] = 1;  
            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];  
            }

            return fib[n];
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a limit: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series using Dynamic Programming:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciDP(i) + " ");
            }
            Console.ReadLine();
        }
    }
}
