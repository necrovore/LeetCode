using System;

namespace _9._Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Problem9
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            string xstr = x.ToString();
            for (int i = 0, j = xstr.Length - 1; i < xstr.Length / 2; i++,j--)
            {
                if (xstr[i] != xstr[j]) return false;
            }
            return true;
        }
    }
}
