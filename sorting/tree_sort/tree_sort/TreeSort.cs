using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_sort {
    class TreeSort {
        /*
         * sort an array in ascending order
         * @param {int[]} [array] - array to sort
         *
         * @return {int[]} [sorted array]
         */
        public int[] Sort(int[] array) { 
            //create binary tree with input array
            BinaryTree tree = new BinaryTree(array);

            return new int[] { 1, 2, 3 };
        }
    }
}