using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heap_sort {
    class HeapSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         */
        public void Sort(int[] array) { 
            
            //heapify array
            for(int i = array.Length / 2 - 1; i >= 0; i--) {

                Heapify(array, array.Length, i);
            }
            //move current max heap to the end and reduce heap until one heap left
            for(int i = array.Length - 1; i >= 0; i--) {
                
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                //re-heapify remaining array
                Heapify(array, i);
            }
        }
        /*
         * heapify an array
         * @param {int[]} [array] - array to heapify
         * @param {int} [size] - heap size
         * @param {int} [maxIndex] - index of current max heap
         */
        public void Heapify(int[] array, int size, int maxIndex = 0) {

            int curMax = maxIndex;
            int childLeft = curMax * 2 + 1;
            int childRight = curMax * 2 + 2;
            //if left child is greater than current largest heap
            if(childLeft < size && array[childLeft] > array[curMax]) {

                curMax = childLeft;
            }
            //if right child is greater than current largest heap
            if(childRight < size && array[childRight] > array[curMax]) {

                curMax = childRight;
            }
            //swap element if current max heap is no longer largest
            if(curMax != maxIndex) {
            
                int temp = array[maxIndex];
                array[maxIndex] = array[curMax];
                array[curMax] = temp;
                //heapify affected sub-tree
                Heapify(array, size, curMax);
            }
        }
    }
}