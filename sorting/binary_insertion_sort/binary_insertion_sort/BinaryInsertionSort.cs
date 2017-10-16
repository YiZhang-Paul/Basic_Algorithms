using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_insertion_sort {
    class BinaryInsertionSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         */
        public void Sort(int[] array) {

            for(int i = 1; i < array.Length; i++) {

                int curIndex = i;
                int target = array[curIndex];
                int insertIndex = BinarySearch(array, target, 0, i - 1);
                //insert current inspecting number
                while(curIndex > insertIndex) {

                    array[curIndex] = array[curIndex - 1];
                    curIndex--;
                }

                array[curIndex] = target;
            }
        }
        /*
         * binary search
         * @param {int[]} [array] - search array
         * @param {int} [target] - search target
         * @param {int} [low] - lower bound of sub-array
         * @param {int} [high] - higher bound of sub-array
         *
         * @return {int} [insertion index]
         */
        public int BinarySearch(int[] array, int target, int low, int high) { 
            //when insertion index is found
            if(low >= high) {

                return target > array[low] ? low + 1 : low;
            }

            int center = (low + high) / 2;
            //when exact match is found
            if(target == array[center]) {

                return center + 1;
            }
            //continue search
            return target < array[center] ?
                BinarySearch(array, target, low, center - 1) : BinarySearch(array, target, high, center + 1);
        }
    }
}