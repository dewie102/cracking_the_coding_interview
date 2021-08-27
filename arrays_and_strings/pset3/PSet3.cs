using System;

namespace pset3
{
    static public class PSet3
    {
        static public void Main()
        {
            char[] test1 = "Mr John Smith    ".ToCharArray();
            TestBruteReverse(test1, 13);
            char [] test2 = "My Name is Zack      ".ToCharArray();
            TestBruteReverse(test2, 15);
        }

        static public void TestBruteReverse(char[] Str, int StrSize)
        {
            BruteReverse.URLify(Str, StrSize);
            Console.WriteLine(Str);
        }
    }
}