using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class FirstAndLastPosition
    {

        //You must write an algorithm with O(log n) runtime complexity.
        //Hence  use binary search

        //5,7,7,8,8,8,10
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] {0,0 };

            result[0] = FindFirst(nums, 0, nums.Length - 1, target);
            result[1] = FindLast(nums, result[0], nums.Length - 1, target);
            return result;
        }

        int FindFirst(int[] nums, int start, int end, int target)
        {
            int first = -1;
            while(start <= end) { 
                int mid = start + (end -  start)/2;
                if (nums[mid] == target) { 
                    first = mid;
                    end = mid - 1;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else if(nums[mid] < target)
                {
                    start = mid + 1;
                }                
            }
            return first;
        }

        int FindLast(int[] nums, int start, int end, int target)
        {
            int last = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    last = mid;
                    start = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
            }
            return last;
        }

    }
}
