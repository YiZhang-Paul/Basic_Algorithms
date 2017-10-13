using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort {
    class BubbleSort {
        /**
         * sort array in ascending order
         * @param {int[]} [array] - array to sort
         * 
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array) {
            for(int i = 0; i < array.Length - 1; i++) {
                bool swapped = false;
                /**
                 * other than swapping unordered pairs, also makes sure to move current max number 
                 * to the end of array, right before the previous max number; thus the algorithm 
                 * checks numbers only up to (array.Length - 1 - i) upon each inner loop, since 
                 * all numbers after that index are larger than the rest and are sorted
                 */
                for(int j = 0; j < array.Length - 1 - i; j++) {
                    if(array[j] > array[j + 1]) {
                        //swap elements
                        array[j] += array[j + 1];
                        array[j + 1] = array[j] - array[j + 1];
                        array[j] -= array[j + 1];
                        swapped = true;
                    }
                }
                //optimization; stop when no more swap occur
                if(!swapped) {
                    break;
                }
            }
            return array;
        }
    }
}