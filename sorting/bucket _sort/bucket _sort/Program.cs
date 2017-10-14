using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucket__sort {
    class Program {
        static void Main(string[] args) {
            double[] array = new double[] { 0.01d, 0.85d, 0.55d, 0.11d, 0.51d, 0.025d, 0.71d, 0.495d, 0.33d, 0.45d };
            BucketSort sorter = new BucketSort();
            sorter.Sort(array);
            Console.WriteLine(string.Join(", ", array)); 
        }
    }
}