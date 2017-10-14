using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucket__sort {
    class BucketSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {double[]} [array] - array to sort
         */
        public void Sort(double[] array) { 
            //bucket to hold all numbers
            var bucket = new Dictionary<int, List<double>>();
            for(int i = 0; i < array.Length; i++) {
                int index = (int)Math.Truncate(array[i] * 10);
                //put number into bucket
                bucket[index] = bucket.ContainsKey(index) ? bucket[index] : new List<double>();
                bucket[index].Add(array[i]);                    
            }
            //sort each bucket
            foreach(var pair in bucket) {
                InsertionSort(pair.Value);
            }
            //put sorted buckets back into a whole array
            for(int i = 0, outputIndex = 0; i < 10; i++) {
                if(bucket.ContainsKey(i)) {
                    foreach(double number in bucket[i]) {
                        array[outputIndex++] = number;
                    }
                }
            }
        }
        /*
         * sort an list using insertion sort
         * @param {List<double>} [list] - list to sort
         */
        public void InsertionSort(List<double> list) {
            for(int i = 1; i < list.Count; i++) {
                int curIndex = i;
                double curValue = list[curIndex];
                //shift larger numbers to the right
                while(curIndex > 0 && list[curIndex - 1] > curValue) {
                    list[curIndex] = list[curIndex - 1];
                    curIndex--;
                }
                //insert current inspecting number
                list[curIndex] = curValue;
            }
        }
    }
}