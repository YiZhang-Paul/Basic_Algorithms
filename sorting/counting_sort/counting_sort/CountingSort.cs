using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counting_sort {
    class CountingSort {
        /**
         * sort an array in ascending order
         * @param {int[]} [array] - array to sort
         * 
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array) {
            //counter filled with 0
            int[] counter = new int[array.Max() + 1];
            Array.Clear(counter, 0, counter.Length);
            //count occurrence of numbers and sum up occurrences
            foreach(int number in array) {
                counter[number]++;
            }
            for(int i = 1; i < counter.Length; i++) {
                counter[i] += counter[i - 1];
            }
            //sort array
            int[] sorted = new int[array.Length];
            foreach(int number in array) {
                sorted[counter[number] - 1] = number;
                counter[number]--;
            }
            return sorted;
        }
    }
}