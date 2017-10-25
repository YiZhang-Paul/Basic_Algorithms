using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleep_sort {
    class Program {
        static void Main(string[] args) {

            int[] array = new int[] { 2, 9, 4, 1, 4 };
            SleepSort sorter = new SleepSort();
            sorter.Sort(array);
        }
    }
}