using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ReverseWords
    {
        public string ReverseWord(string s)
        {
            int start = 0;
            char[] c = s.ToCharArray();
            for (; start < s.Length;)
            {
                int end = start;
                while (end < s.Length && s[end] != ' ')
                {
                    end++;
                }
                //Reverse start to end
                ReverseArr(c, start, end - 1);
                start = end + 1;
            }

            return new String(c);
        }

        void ReverseArr(char[] s, int start, int end)
        {
            while (start < end)
            {
                var temp = s[start];
                s[start] = s[end];
                s[end] = temp;

                start++;
                end--;
            }
        }


    }
}
