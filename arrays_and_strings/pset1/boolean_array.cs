using System;

namespace pset1
{
    static public class BooleanArray
    {
        static public bool IsUnique(string str)
        {
            bool[] characters = new bool[256];

            if(str.Length > 256)
                return false;

            foreach (char c in str)
            {
                if(characters[(int)c])
                    return false;

                characters[(int)c] = true;
            }

            return true;
        }
    }
}