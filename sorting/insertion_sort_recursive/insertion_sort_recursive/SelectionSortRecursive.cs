using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort_recursive {
    class SelectionSortRecursive {
        /**
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         * @param {int} [visit] - current number of visits to array
         * 
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array, int visit = 0) {
            int curIndex = visit;
            int curValue = array[curIndex];
            //keep shifting larger numbers toward original index of inspecting value
            while(curIndex > 0 && array[curIndex - 1] > curValue) {
                array[curIndex] = array[curIndex - 1];
                curIndex--;
            }
            //insert original value at correct index
            array[curIndex] = curValue;
            //continue next visit until all elements are sorted
            return visit == array.Length - 1 ? array : Sort(array, visit + 1);
        }
    }
}