using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bogo_sort {
    class BogoSort {
        /*
         * sort an array in ascending order
         * @param {int[]} [array] - array to sort
         *
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array) {
            int[] output = new int[array.Length];
            array.CopyTo(output, 0);
            //keep permuting until array is sorted
            while(!IsSorted(output)) {
                var numbers = new List<int>(array); 
                for(int i = 0; i < output.Length; i++) {
                    //pick random number from array
                    int index = new Random().Next(0, numbers.Count);
                    output[i] = numbers[index];
                    numbers.RemoveAt(index);
                }
            }
            return output;
        }
        /*
         * check if an array is sorted in ascending order
         * @param {int[]} [array] - array to check
         *
         * @return {bool} [test result]
         */
        public bool IsSorted(int[] array) {
            for(int i = 0; i < array.Length - 1; i++) {
                if(array[i] > array[i + 1]) {
                    return false;
                }
            }
            return true;
        }
    }
}