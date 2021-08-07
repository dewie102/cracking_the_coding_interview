

namespace pset1
{
    static public class BitVector
    {
        static public bool IsUnique(string str)
        {
            int checker = 0;
            foreach (char c in str)
            {
                int val = c - 'a';
                if((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (1 << val);
            }
            return true;
        }
    }
}