using System;

namespace _4._Median_of_Two_Sorted_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Solution().FindMedianSortedArrays(new int[] { 1,2}, new int[] { 3,4 });
        }
    }
    public class Solution
    {

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] comb = new int[nums1.Length + nums2.Length];
            int k = 0;
            int i = 0, j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    comb[k] = nums1[i];
                    k++;
                    comb[k] = nums2[j];
                    k++;
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    comb[k] = nums1[i];
                    k++;
                    i++;
                }
                else
                {
                    comb[k] = nums2[j];
                    k++;
                    j++;
                }
            }

            while (i < nums1.Length)
            {
                comb[k] = nums1[i];
                k++;
                i++;
            }

            while (j < nums2.Length)
            {
                comb[k] = nums2[j];
                k++;
                j++;
            }

            if (comb.Length % 2 != 0) return comb[comb.Length / 2];
            return (double)((double)(comb[comb.Length / 2 - 1] + comb[comb.Length / 2]) / 2);

            //double f = (double)comb.Length / 2;
            //return f;
        }
    }
}
