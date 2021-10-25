using System;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrequencyCounter frequencyCounter = new FrequencyCounter();
            var ans = frequencyCounter.Same(new int[] { 1, 2, 3 }, new int[] { 8, 1, 4 });
            Console.WriteLine($"Same Array {ans}");
            Console.WriteLine($"Is Anagram {frequencyCounter.IsAnagram("alex", "xela")}");
        }
    }
}
