using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_sort {
    class CycleSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         */
        public void Sort(int[] array) {
            for(int i = 0; i < array.Length - 1; i++) {
                int curIndex = i;
                int curNumber = array[curIndex];
                int curCycle = 0;
                while(curCycle == 0 || curIndex != i) {
                    curIndex = i;
                    curCycle++;
                    //find correct index to insert
                    for(int j = curIndex + 1; j < array.Length; j++) {
                        if(curNumber > array[j]) {
                            curIndex++;
                        }
                    }
                    //skip current cycle if starting number is already at correct index
                    if(curCycle == 1 && curIndex == i) {
                        continue;
                    }
                    //ignore duplicate numbers
                    while(curNumber == array[curIndex]) {
                        curIndex++;
                    }
                    //insert number
                    int temp = array[curIndex];
                    array[curIndex] = curNumber;
                    curNumber = temp;
                }
            }
        }
    }
}