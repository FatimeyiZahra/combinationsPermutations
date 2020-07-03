using System;

namespace combinationsPermutations
{
    class Program
    {
        //#region combination basic
        //private static void permute(String str, int l, int r)
        //{
        //    if (l == r)
        //        Console.WriteLine(str);
        //    else
        //    {
        //        for (int i = l; i <= r; i++)
        //        {
        //            str = swap(str, l, i);
        //            permute(str, l + 1, r);
        //            str = swap(str, l, i);
        //        }
        //    }
        //}
        ///** 
        //* Swap Characters at position 
        //* @param a string value 
        //* @param i position 1 
        //* @param j position 2 
        //* @return swapped string 
        //*/
        //public static String swap(String a, int i, int j)
        //{
        //    char temp;
        //    char[] charArray = a.ToCharArray();
        //    temp = charArray[i];
        //    charArray[i] = charArray[j];
        //    charArray[j] = temp;
        //    string s = new string(charArray);
        //    return s;
        //}
        //// Driver Code 
        //public static void Main()
        //{
        //    String str = "zrhaa";
        //    int n = str.Length;
        //    permute(str, 0, n - 1);
        //}
        //#endregion
        #region usefull permutation
        static void generate(char[] arr, int i, String s, int len)
        {
            // base case 
            if (i == 0) // when len has been reached 
            {
                // print it out 
                Console.WriteLine(s);

                // cnt++; 
                return;
            }

            // iterate through the array 
            for (int j = 0; j < len; j++)
            {

                // Create new string with next character 
                // Call generate again until string has 
                // reached its len 
                String appended = s + arr[j];
                generate(arr, i - 1, appended, len);
            }

            return;
        }

        // function to generate all possible passwords 
        static void crack(char[] arr, int len)
        {
            // call for all required lengths 
            for (int i = 1; i <= len; i++)
            {
                generate(arr, i, "", len);
            }
        }

        // Driver code 
        public static void Main(String[] args)
        {
            char[] arr = { 'a', 'b', 'c' };
            int len = arr.Length;
            crack(arr, len);
        }

    }
    #endregion

}

//----------------------Phyton--------------------------------------------------
//def toString(List): 
//    return ''.join(List)

//# Function to print permutations of string 
//# This function takes three parameters: 
//# 1. String 
//# 2. Starting index of the string 
//# 3. Ending index of the string. 
//def permute(a, l, r): 
//    if l==r: 
//        print toString(a)
//    else: 
//        for i in xrange(l, r+1) :
//            a[l], a[i] = a[i], a[l]
//            permute(a, l+1, r)
//            a[l], a[i] = a[i], a[l] # backtrack 
  
//# Driver program to test the above function 
//string = "ABC"
//n = len(string)
//a = list(string)
//permute(a, 0, n-1)
