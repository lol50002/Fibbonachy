using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(10));
            Console.ReadKey();
        }
        

        public static int Fib(int n)
        {
            int[] chisla = new int[100];

            if (n <= 1) return n;

            if (chisla[n] != 0) return chisla[n];

            chisla[n] = Fib(n - 2) + Fib(n - 1);
            return chisla[n];
        }
    }
}
