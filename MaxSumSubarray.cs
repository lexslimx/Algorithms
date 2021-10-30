using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class MaxSumSubarray
    {

        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int start = 0;

            for (; start < nums.Length; start++)
            {
                //for each digit in nums, try to construct a sum greater than max
                int sum = 0;
                int current = start;
                while (current < nums.Length && nums[current] + sum > max)
                {
                    sum = nums[current] + sum;
                    current++;
                    max = Math.Max(max, sum);
                }
            }

            return max;
        }
    }
}
