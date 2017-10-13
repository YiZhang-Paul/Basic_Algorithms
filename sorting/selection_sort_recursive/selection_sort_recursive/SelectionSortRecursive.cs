using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort_recursive {
    class SelectionSortRecursive {
        /**
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         * @param {int} [visit] - current number of visits to array
         * 
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array, int visit = 0) {
            if(visit == array.Length) {
                return array;
            }
            //find minimum value and swap to beginning of array
            int minIndex = visit;
            int min = array[minIndex];
            for(int i = minIndex + 1; i < array.Length; i++) {
                if(array[i] < min) {
                    min = array[i];
                    minIndex = i;
                }
            }
            //swap elements
            array[minIndex] = array[visit];
            array[visit] = min;
            return Sort(array, visit + 1);
        }
    }
}