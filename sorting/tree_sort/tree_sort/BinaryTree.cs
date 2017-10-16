using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_sort {
    class BinaryTree {
        public Node Root { get; set; }

        public BinaryTree() { 
        }
        /*
         * @param {int[]} [array] - input array for binary tree
         */
        public BinaryTree(int[] array) {

            Root = CreateTree(array);
        }
        /*
         * populate binary tree
         * @param {int[]} [array] - input array for binary tree
         *
         * @return {Node} [root node of binary tree]
         */
        public Node CreateTree(int[] array) {

            var root = new Node(array[0]);

            foreach(int number in array.Skip(1)) {
                root = AddNode(root, number);
            }

            return root;
        }
        /*
         * add new node
         * @param {Node} [root] - root node
         * @param {int} [value] - value of new node
         * 
         * @return {Node} [root node]
         */
        public Node AddNode(Node root, int value) {

            if(value < root.Value) {

                root.Left = root.Left == null ? new Node(value) : AddNode(root.Left, value);
            } 
            else {

                root.Right = root.Right == null ? new Node(value) : AddNode(root.Right, value);
            }

            return root;
        }
    }
}