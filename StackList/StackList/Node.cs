using System;
using System.Collections.Generic;
using System.Text;

namespace StackList
{
    class Node
    {
        private int value;
        public Node next;

        public int Value { get => value; set => this.value = value; }

        public Node(int value)
        {
            this.value = value;
        }
    }
}
