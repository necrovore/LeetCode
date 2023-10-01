using System;

namespace _557._Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedWords = new Problem557().ReverseWords("Let's take");
        }

        
    }

    public class Problem557
    {
        public string ReverseWords(string s)
        {
            Char[] sChars = s.ToCharArray();
            for (int i = 0; i < sChars.Length; i++)
            {
                for (int j = i; j < sChars.Length; j++)
                {
                    if (j == sChars.Length-1 || sChars[j + 1] == ' ')
                    {
                        this.reverse(sChars, i, j );
                        j = j + 1;
                        i = j + 1;
                    }
                }
                
            }
            return new string(sChars);
        }

        public void reverse(Char[] charArray, int startIndex, int endIndex)
        {
            while(startIndex<endIndex)
            {
                char temp = charArray[startIndex];
                charArray[startIndex] = charArray[endIndex];
                charArray[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
    }
}


