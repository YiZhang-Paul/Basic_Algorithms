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

            CreateTree(array);
        }
        /*
         * populate binary tree
         * @param {int[]} [array] - input array for binary tree
         */
        public void CreateTree(int[] array) {

            Root = new Node(array[0]);

            foreach(int number in array.Skip(1)) {

                Root = AddNode(Root, number);
            }
        }
        /*
         * add new node to binary tree
         * @param {Node} [root] - root node of binary tree
         * @param {int} [value] - value of new node
         * 
         * @return {Node} [root node of binary tree]
         */
        public Node AddNode(Node root, int value) {
            //traverse tree base on current value
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