using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort_recursive {
    class QuickSortRecursive {
        /**
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         * @param {int} [beginIndex] - beginIndex index of partition
         * @param {int} [endIndex] - endIndex index of partition 
         */
        public void Sort(int[] array, int beginIndex, int endIndex) { 
            if(beginIndex < endIndex) {
                int pivot = array[endIndex];
                int startIndex = beginIndex;
                for(int i = beginIndex; i < endIndex; i++) {
                    if(array[i] < pivot) {
                        //swap elements
                        int tempValue = array[i];
                        array[i] = array[startIndex];
                        array[startIndex] = tempValue;
                        startIndex++;
                    }
                }
                //swap pivot to correct position
                array[endIndex] = array[startIndex];
                array[startIndex] = pivot; 
                //sort partitions
                Sort(array, beginIndex, startIndex - 1);
                Sort(array, startIndex + 1, endIndex);
            }
        }
    }
}