using System;
using MoreLinq;
using MoreLinq.Extensions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MoreLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------APPEND---------------------------------------------------------------------------------------
            string[] fruits = { "apple", "banana", "orange", "cheryy" };

            IEnumerable<string> result1 = fruits.RandomSubset(3);

            
            Console.WriteLine(result1.ToDelimitedString(","));

            
            //System.Linq.Enumerable.Append()

            Console.ReadKey();
        }
    }
}
