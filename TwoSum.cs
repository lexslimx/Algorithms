using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class TwoSum
    {

        public int[] GetTwoSum(int[] nums, int target)
        {
            int[] ans = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (map.ContainsKey(nums[i]))
                {
                    ans[0] = i;
                    ans[1] = map[nums[i]];
                }
                else
                {
                    if (!map.ContainsKey(diff)) map.Add(diff, i);
                }
            }

            return ans;
        }

        public int[] TwoSumSortedArray(int[] numbers, int target)
        {
            int[] ans = new int[2];
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum > target)
                {
                    right--;
                    continue;
                }
                else if (sum < target)
                {
                    left++;
                    continue;
                }
                else if (sum == target)
                {
                    ans[0] = left;
                    ans[1] = right;
                    return ans;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return ans;
        }


    }
}
