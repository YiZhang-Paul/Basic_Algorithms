using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort_recursive {
    class BubbleSortRecursive {
        /**
         * sort an array in ascending order recursively
         * @param {int[]} [array] - array to sort
         * 
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array) {
            if(array.Length == 1) {
                //stop when no more elements need to be sorted
                return array;
            }
            //always push current max number to the end of current array
            for(int i = 0; i < array.Length - 1; i++) {
                if(array[i] > array[i + 1]) {
                    //swap elements
                    array[i] += array[i + 1];
                    array[i + 1] = array[i] - array[i + 1];
                    array[i] -= array[i + 1];
                }
            }
            //split sorted and unsorted array
            int[] unsorted = array.Take(array.Length - 1).ToArray();
            int[] sorted = array.Skip(array.Length - 1).ToArray();
            return Sort(unsorted).Concat(sorted).ToArray();
        }
    }
}