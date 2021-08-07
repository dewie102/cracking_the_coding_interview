using System;

namespace pset1
{
    static public class Program
    {
        static public void Main()
        {
            const string test1 = "abcdefghi";
            const string test2 = "aa";
            const string test3 = "abcdefghic";
            const string test4 = "fdsaerwq%^vbnm%";

            Console.WriteLine(Utils.IsUnique(test1));
            Console.WriteLine(Utils.IsUnique(test2));
            Console.WriteLine(Utils.IsUnique(test3));
            Console.WriteLine(Utils.IsUnique(test4));
        }
    }
}
