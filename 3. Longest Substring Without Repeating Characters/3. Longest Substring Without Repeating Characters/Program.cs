using System;

namespace _3._Longest_Substring_Without_Repeating_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Solution().LengthOfLongestSubstring("abcabcbb");
        }
    }

    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            char[] charArray = s.ToCharArray();
            string substr = "";

            for (int i = 0; i < charArray.Length; i++)
            {
                string st = charArray[i].ToString();
                for (int j = i+1; j < charArray.Length; j++)
                {
                    if (st.Contains(charArray[j])) break;
                    st = st + charArray[j];
                }
                if (substr.Length < st.Length) substr = st;
            }
            return substr.Length;
        }
    }
}
