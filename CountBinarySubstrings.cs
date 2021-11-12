using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public  class CountBinarySubstrings
    {
        public int CountSubstrings(string s)
        {
            int[] charGroups = new int[s.Length];
            var arr = s.ToCharArray();
            int count = 0;
            charGroups[0] = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (arr[i - 1] != arr[i])
                {
                    charGroups[++count] = 1;
                }
                else
                {
                    charGroups[count]++;
                }
            }

            int ans = 0;
            for (int i = 1; i <= count; i++)
            {
                ans += Math.Min(charGroups[i - 1], charGroups[i]);
            }
            return ans;
        }
    }
}
