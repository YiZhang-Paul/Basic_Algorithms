using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_sort {
    class TreeSort {
        /*
         * sort an array in ascending order - this algorithm modifies the original array
         * @param {int[]} [array] - array to sort
         */
        public void Sort(int[] array) { 
            //create binary tree
            BinaryTree tree = new BinaryTree(array);
            //travers binary tree in order 
            int counter = 0;
            Traverse(tree.Root, array, ref counter);
        }
        /*
         * traverse binary tree in order and record all node values
         * @param {Node} [root] - root node of binary tree
         * @param {int[]} [array] - output array
         * @param {int} [counter] - total visited nodes
         */
        public void Traverse(Node root, int[] array, ref int counter) {
            //visit left-most node for all branches
            if(root.Left != null) {

                Traverse(root.Left, array, ref counter);
            } 
            //record node value
            array[counter++] = root.Value;
            //visit all right branches for current node
            if(root.Right != null) {

                Traverse(root.Right, array, ref counter);
            }
        }
    }
}