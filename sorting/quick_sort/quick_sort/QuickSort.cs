using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort {
    class QuickSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         * @param {int} [beginIndex] - beginning index of sub-array
         * @param {int} [endIndex] - ending index of sub-array
         */
        public void Sort(int[] array, int beginIndex, int endIndex) { 
            //stack to store current sub-array boundaries
            Stack<int> stack = new Stack<int>(new int[] { endIndex, beginIndex });
            while(stack.Count > 0) {
                int begin = stack.Pop();
                int end = stack.Pop();
                //partition array
                int pivotIndex = Partition(array, begin, end);
                //record sub arrays
                if(pivotIndex - 1 > begin) {
                    stack.Push(pivotIndex - 1);
                    stack.Push(begin);
                }
                if(pivotIndex + 1 < end) {
                    stack.Push(end);
                    stack.Push(pivotIndex + 1);
                }
            }
        }
        /*
         * partition array into sub-arrays
         * @param {int[]} [array] - array to partition
         * @param {int} [begin] - beginning index to partition
         * @param {int} [end] - ending index to partition
         *
         * @return {int} [pivot index]
         */
        public int Partition(int[] array, int begin, int end) { 
            int pivot = array[end];
            int curIndex = begin;
            for(int i = begin; i < end; i++) {
                if(array[i] < pivot) {
                    int temp = array[i];
                    array[i] = array[curIndex];
                    array[curIndex] = temp;
                    curIndex++;
                }
            }
            //move pivot to correct index
            array[end] = array[curIndex];
            array[curIndex] = pivot;
            return curIndex;
        }
    }
}