using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge_sort_recursive {
    class MergeSortRecursive {
        /**
         * sort an array in ascending order
         * @param {int[]} [array] - array to sort
         * @param {int} [leftIndex] - begin index of sub-array
         * @param {int} [rightIndex] - end index of sub-array
         */
        public void Sort(int[] array, int beginIndex, int endIndex) {
            if(beginIndex < endIndex) {
                int centerIndex = beginIndex + (endIndex - beginIndex) / 2;
                //sort both halves
                Sort(array, beginIndex, centerIndex);
                Sort(array, centerIndex + 1, endIndex);
                //copy both halves
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
                    //merge two halves
                    array[i] = side[0];
                    side.RemoveAt(0);
                }
            }
        }
    }
}