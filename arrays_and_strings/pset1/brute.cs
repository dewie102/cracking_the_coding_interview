using System;

namespace pset1
{
    static public class Brute
    {
        static public bool IsUnique(string str)
        {
            for(int i = 0; i < str.Length - 1; i++)
            {
                for(int j = i + 1; j < str.Length; j++)
                {
                    if(str[j] == str[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}