using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pset2
{
    public class Brute
    {
        static public bool IsPermutation(string str1, string str2)
        {

            string longer = str1.Length > str2.Length ? str1 : str2;
            string shorter = str1.Length < str2.Length ? str1 : str2;

            for(int i = 0; i < shorter.Length; i++)
            {
                for(int j = 0; j < longer.Length; j++)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
