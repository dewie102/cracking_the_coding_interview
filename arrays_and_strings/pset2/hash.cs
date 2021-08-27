using System;
using System.Collections;

namespace pset2
{
    static public class Hash
    {
        static public bool IsPermutation(string str1, string str2)
        {
            string larger = str1.Length > str2.Length ? str1 : str2;
            string smaller = str1.Length < str2.Length ? str1 : str2;

            Hashtable strHash = new();
            
            foreach (char c in larger)
            {
                strHash.Add(c, 1);
            }

            foreach (char c in smaller)
            {
                if(!strHash.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
