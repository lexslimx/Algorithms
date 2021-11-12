using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class SubstringLength
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 1;

            for (int start = 0; start < s.Length; start++)
            {
                HashSet<char> charSet = new HashSet<char>();
                int length = 1;
                int index = start;
                while (index < s.Length && !charSet.Contains(s[index]))
                {
                    length++;
                    charSet.Add(s[index]);
                    index++;
                }
                maxLength = Math.Max(length, maxLength);

            }
            return maxLength;
        }
    }
}
