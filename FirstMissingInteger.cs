using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class FirstMissingInteger
    {
        public int FirstMissingPositive(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hs.Contains(nums[i]))
                    continue;
                hs.Add(nums[i]);
            }
            int minVal = 1;
            for (minVal = 1; minVal <= nums.Length; minVal++)
            {
                if (!hs.Contains(minVal))
                    return minVal;
            }
            return minVal;
        }
    }
}
