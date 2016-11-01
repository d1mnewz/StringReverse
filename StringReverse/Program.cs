using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        public static void ReverseWithXOR(ref char[] arr)
        {
            int start = 0;
            int end = arr.Count() -1;
            while (start < end)
            {
                arr[start] ^= arr[end];
                arr[end] ^= arr[start];
                arr[start] ^= arr[end];
                ++start;
                --end;
            }
           
        }
        public static void ReverseArray(ref char[] arr)
        {
            char tmp;
            int end = arr.Count();
            for (int i = 0; i < end/2; i++)
            {
                tmp = arr[i];
                arr[i] = arr[end - i - 1];
                arr[end - i - 1] = tmp;

            }

        }
        static void Main(string[] args)
        {
           

            // to do some cool calculations with average time elapsed with long distance
            // check native methods
            char[] str = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd', '!'};
            Console.WriteLine(str);
            var watch = Stopwatch.StartNew();
            ReverseWithXOR(ref str);
            watch.Stop();
            var elapsedTime = watch.Elapsed;
            Console.WriteLine(elapsedTime);

            Console.WriteLine(str);
            watch = Stopwatch.StartNew();
            ReverseArray(ref str);
            watch.Stop();
            elapsedTime = watch.Elapsed;
            Console.WriteLine(elapsedTime);
            // second is much faster!

            Console.WriteLine(str);

        }
    }
}
