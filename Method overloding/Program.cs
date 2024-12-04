using System;

namespace Method_overloding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void add(int FN, int SN , params int[] TN)
        {
            Console.WriteLine("sum: {0}", FN + SN);
        }
        public static void add(int FN, int SN, int[] TN)
        {
            Console.WriteLine("sum: {0}", FN + SN);
        }
    }
}
