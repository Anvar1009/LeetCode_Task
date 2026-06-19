using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Task
{
    public static class Solution
    {
        public static int[] TwoSum(int[] nums, int k)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for( int j = i; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == k)
                    {
                        return new int[] { i, j };
                    }

                }
            }
            return null;
        }
    }
}
