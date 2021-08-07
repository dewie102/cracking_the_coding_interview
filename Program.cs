using System;

namespace cracking_the_coding_interview
{
    static public class Program
    {
        static public void Main(string[] args)
        {
            if(args.Length > 0) {
                for(int i = 0; i < args.Length; i++) {
                    Console.WriteLine(args[i]);
                }
            }

            Console.WriteLine("Hello World!");
        }
    }
}
