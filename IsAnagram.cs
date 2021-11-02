using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class IsAnagram
    {
        public bool Same(int[] arr, int[] nums)
        {
            if(arr.Length != nums.Length) return false;
            //same if eeveery value in arr has it's valuue sqquared in nums
            //The frequeency of the values must be the same
            //The order doesn' matter
            //e.g 1,2,3 => 4,1,9

            //Push the frequencies into a map of count and value
            //For each element in arr, check if the map has the squaree and coun >= 1
            //decremen map value key
            //if we get to end return true 
            //shoould map be eempty?

            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i])) map[nums[i]]++;
                map.Add(nums[i], 1);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var square = arr[i] * arr[i];
                if(map.ContainsKey(square) && map[square] > 0) map[square]--;
                else
                {
                    return false;
                }                
            }

            return true;
        }

        public bool IsAnnagram(string s1, string s2)
        {
            if(s1.Length != s2.Length) return false;
            //count the characters in s1
            //iterate over s2 and count the characters while deducting from the map
            //at the end the map should have no characters left
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s1.ToCharArray())
            {
                if (map.ContainsKey(c)) map[c] ++;
                else map.Add(c, 1);               
            }

            foreach (char c in s2.ToCharArray())
            {
                if (map.ContainsKey(c) && map[c] > 0) map[c]--;
                else return false;
            }

            if (map.Values.Any(e => e > 0)) return false;

            return true;
        }
    }
}
