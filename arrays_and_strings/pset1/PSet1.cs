using System;
using System.Collections.Generic;

namespace pset1
{
    static public class PSet1
    {
        static public void Main()
        {
            List<string> tests = new();
            tests.Add("abcdefghi");
            tests.Add("aa");
            tests.Add("Aa");
            tests.Add("abcdefghic");
            tests.Add("fdsaerwq%^vbnm%");

            Console.WriteLine("Testing Hash: ");
            TestHashExample(tests);
            Console.WriteLine("Testing Brute: ");
            TestBruteExample(tests);
            Console.WriteLine("Testing Boolean Array: ");
            TestBooleanArrayExample(tests);
            Console.WriteLine("Testing BitVector: ");
            TestBitVectorExample(tests);
        }

        static public void TestHashExample(List<string> Strs)
        {
            foreach (string str in Strs)
            {
                Console.WriteLine(Hash.IsUnique(str));
            }
        }

        static public void TestBruteExample(List<string> Strs)
        {
            foreach (string str in Strs)
            {
                Console.WriteLine(Brute.IsUnique(str));
            }
        }

        static public void TestBooleanArrayExample(List<string> Strs)
        {
            foreach (string str in Strs)
            {
                Console.WriteLine(BooleanArray.IsUnique(str));
            }
        }

        static public void TestBitVectorExample(List<string> Strs)
        {
            foreach (string str in Strs)
            {
                Console.WriteLine(BitVector.IsUnique(str));
            }
        }
    }
}
