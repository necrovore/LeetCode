using System;
using System.Collections.Generic;
using System.Linq;

namespace _1512._Number_of_Good_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Solution().NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 });
        }
    }

    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int pairCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                pairCount += nums.Where((value, index) => index > i && nums[index] == nums[i]).Count();
                //for (int j = i+1; j < nums.Length; j++)
                //{
                //    if (nums[j] == nums[i])
                //    {
                //        pairCount++;
                //    }
                //}
            }
            return pairCount;
        }

    }
}
