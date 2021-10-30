using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciSequence fib = new FibonacciSequence();
            var ans = fib.FibTopDown(3);
            Console.WriteLine(ans);
        }
    }
}
