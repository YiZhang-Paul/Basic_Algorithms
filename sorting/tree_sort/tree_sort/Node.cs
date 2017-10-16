using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_sort {
    class Node {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node() { 
        }
        /*
         * @param {int} [value] - node value
         */
        public Node(int value) {

            Value = value;
        }
    }
}