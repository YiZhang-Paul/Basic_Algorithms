using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radix_sort {
    class RadixSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         */
        public void Sort(int[] array) {
            //total digit places to sort
            int places = array.Max().ToString().Length;
            for(int i = 0, exponent = 1; i < places; exponent *= 10, i++) {
                int[] counter = new int[array.Length];
                Array.Clear(counter, 0, counter.Length);
                //count digit occurrences
                for(int j = 0; j < array.Length; j++) {
                    counter[array[j] / exponent % 10]++;
                }
                for(int j = 1; j < array.Length; j++) {
                    counter[j] += counter[j - 1];
                }
                //output array
                int[] output = new int[array.Length];
                for(int j = array.Length - 1; j >= 0; j--) {
                    int digit = array[j] / exponent % 10;
                    output[counter[digit] - 1] = array[j];
                    counter[digit]--;
                }
                output.CopyTo(array, 0);
            }
        }
    }
}