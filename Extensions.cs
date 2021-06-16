using System;
using System.Collections.Generic;
using System.Text;

namespace MoreLinqExamples
{
    static class Extensions
    {
        public static IEnumerable<TSource> Filter<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource element in source)
            {             
                if (predicate(element))
                {
                    yield return element;
                }
            }
        }
    }
}
