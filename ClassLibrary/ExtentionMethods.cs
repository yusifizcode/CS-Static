using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            if (num % 2 !=0)
                return true;
            
            return false;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
                return true;
            
            return false ;
        }
        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            return str.ToUpper();
        }


        public static int[] GetValueIndexes(this string str, char chr)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==chr)
                {
                    count++;
                }
            }
            int[] arr = new int[count];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    arr[j]=i;
                    j++;
                }
            }
            return arr;
        }

    }
}
