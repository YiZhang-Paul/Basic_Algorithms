using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bogo_sort {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[] { 2, 14, 11, 16}; 
            //int[] array = new int[] { 2, 14, 11, 16, 82, 4, 34, 51, 1, 4 }; -> take forever 
            BogoSort sorter = new BogoSort();
            Console.WriteLine(string.Join(", ", sorter.Sort(array)));
        }
    }
}