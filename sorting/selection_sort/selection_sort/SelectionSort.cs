using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort {
    class SelectionSort {
        /**
         * sort an array in ascending order
         * @param {int[]} [array] - array to sort
         * 
         * @return {int[]} [array]
         */
        public int[] Sort(int[] array) {
            var unsorted = new List<int>(array);
            var sorted = new List<int>(array.Length);
            while(unsorted.Count > 0) {
                //or simply: int min = unsorted.Min();
                int min = unsorted[0];
                foreach(int number in unsorted) {
                    //or simply: min = Math.Min(min, number);
                    min = number < min ? number : min;
                }
                unsorted.Remove(min);
                sorted.Add(min);
            }
            return sorted.ToArray();
        }
    }
}