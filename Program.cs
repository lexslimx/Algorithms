using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstMissingInteger arr = new FirstMissingInteger();
            var ans = arr.FirstMissingPositive(new int[] { 1, 2, 0 });
            Console.WriteLine(ans);
        }
    }
}
