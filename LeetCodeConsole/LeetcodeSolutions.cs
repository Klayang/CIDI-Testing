using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsole
{
    public class LeetcodeSolutions
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new();
            for (int i = 0; i < nums.Length; i += 1)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }
                else
                {
                    dict[nums[i]] = i;
                }
            }
            return Array.Empty<int>();
        }
    }
}
