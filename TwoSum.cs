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
    }
