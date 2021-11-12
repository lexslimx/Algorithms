using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountBinarySubstrings arr = new CountBinarySubstrings();
            var ans = arr.CountSubstrings("00110011");
            Console.WriteLine(ans);
        }
    }
}
