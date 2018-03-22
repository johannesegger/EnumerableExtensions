using System;
using System.Collections.Generic;
using System.Linq;

namespace EnumerableExtensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IGrouping<string, string>> GroupAdjacent(this IEnumerable<string> list)
        {
            return Enumerable.Empty<IGrouping<string, string>>();
        }
    }
}
