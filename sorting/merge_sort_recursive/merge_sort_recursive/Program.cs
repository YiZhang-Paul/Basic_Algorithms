using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort_recursive {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[] { 2, 14, 11, 16, 82, 4, 34, 51, 1, 4 };
            MergeSortRecursive sorter = new MergeSortRecursive();
            Console.WriteLine(string.Join(", ", sorter.Sort(array)));
        }
    }
}