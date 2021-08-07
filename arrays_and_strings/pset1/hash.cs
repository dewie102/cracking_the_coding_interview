using System.Collections;

namespace pset1
{
    static public class Utils
    {
        static public bool IsUnique(string str)
        {
            Hashtable characterHash = new(str.Length);

            for(int i = 0; i < str.Length; i++)
            {
                if(characterHash.Contains(str[i]))
                {
                    return false;
                }

                characterHash.Add(str[i], 1);
            }

            return true;
        }
    }
}