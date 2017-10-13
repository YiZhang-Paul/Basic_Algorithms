using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort {
    class InsertionSort {
        /**
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         * 
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array) {
            for(int i = 0; i < array.Length; i++) {
                int curIndex = i;
                int curValue = array[curIndex];
                //keep shifting larger numbers towards original index of current inspecting value
                while(curIndex > 0 && array[curIndex - 1] > curValue) {
                    array[curIndex] = array[curIndex - 1];
                    curIndex--;
                }
                //insert original value at appropriate index
                array[curIndex] = curValue;
            }
            return array;
        }
    }
}