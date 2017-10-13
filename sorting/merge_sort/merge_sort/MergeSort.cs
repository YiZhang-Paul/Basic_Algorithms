using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort {
    class MergeSort {
        /**
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         */
        public void Sort(int[] array) {
            //start from smallest sub-arrays
            for(int subSize = 1; subSize <= array.Length - 1; subSize *= 2) {
                for(int beginIndex = 0; beginIndex < array.Length - 1; beginIndex += subSize * 2) {
                    //determine center index and end index for arrays in current merge
                    int centerIndex = beginIndex + subSize - 1;
                    int endIndex = Math.Min(beginIndex + subSize * 2 - 1, array.Length - 1);
                    //retrieve both halves
                    List<int> leftHalf = array.Skip(beginIndex).Take(centerIndex - beginIndex + 1).ToList();
                    List<int> rightHalf = array.Skip(centerIndex + 1).Take(endIndex - centerIndex).ToList();
                    for(int i = beginIndex; i <= endIndex; i++) {
                        //determine which side of sub-arrays to pick number
                        List<int> side;
                        if(leftHalf.Count == 0 || rightHalf.Count == 0) {
                            side = leftHalf.Count == 0 ? rightHalf : leftHalf;
                        } else {
                            side = leftHalf[0] < rightHalf[0] ? leftHalf : rightHalf;
                        }
                        //merge both halves
                        array[i] = side[0];
                        side.RemoveAt(0);
                    }
                }
            }
        }
    }
}