using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class RotateArray
    {
        public int[] RotateUsingReverse(int[] nums, int k)
        {
            //Take care of cases where k = length of array
            k = k % nums.Length;
            //nums=1,2,3,4,5,6,7 , k = 3
            //reverse all numbers
            Reverse(nums, 0, nums.Length - 1);
            //7,6,5,4,3,2,1

            //reverse first k numers
            Reverse(nums, 0, k-1);
            //5,6,7,4,3,2,1

            //reverse numbers after k
            //5.6.7.1.2.3.4
            Reverse(nums, k, nums.Length - 1);

            return nums;
        }


        private void Reverse(int[] nums, int start, int end)
        {
            while(start < end)
            {
                int temp = nums[end];
                nums[end] = nums[start];
                nums[start] = temp;
            }
        }
    }
}
