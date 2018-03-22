using System;
using System.Collections.Generic;
using System.Linq;
using EnumerableExtensions;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new[] { "Johannes", "Geri", "Johannes", "Roland", "Daniel" };

            // Imperativ
            var filteredList = new List<string>();
            foreach (var item in list)
            {
                if (item.Length > 5)
                {
                    filteredList.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", filteredList));

            // Deklarativ
            var filteredList2 = list
                .Where(item => item.Length > 5)
                .ToList();
            Console.WriteLine(string.Join(", ", filteredList2));

            list.GroupAdjacent();
        }
    }
}
