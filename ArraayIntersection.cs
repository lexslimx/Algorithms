using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class ArraayIntersection
    {
        public ArraayIntersection()
        {

        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            List<int> ans = new List<int>();

            for (var i = 0; i < nums1.Length; i++)
            {
                if (map.ContainsKey(nums1[i]))
                    map[nums1[i]]++;
                else
                    map.Add(nums1[i], 1);
            }

            for (var i = 0; i < nums2.Length; i++)
            {
                if (map.ContainsKey(nums2[i]) && map[nums2[i]] > 0)
                {
                    ans.Add(nums2[i]);
                    map[nums2[i]]--;
                }
            }

            return ans.ToArray();
        }
    }
}
