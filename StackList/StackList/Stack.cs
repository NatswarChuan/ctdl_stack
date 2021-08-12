using System;
using System.Collections.Generic;
using System.Text;

namespace StackList
{
    class Stack
    {
        //fields
        private Node first;
        private int count;

        //constructors
        public Stack()
        {
            this.count = 0;
        }

        //properties
        public int Count { get => count; }

        //method
        /// <summary>
        /// Push: insert value in first
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.count == 0)
            {
                this.first = node;
            }
            else
            {
                node.next = this.first;
                this.first = node;
            }
            this.count++;
        }

        /// <summary>
        /// Peek: return first value
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return this.first.Value;
        }

        /// <summary>
        /// Pop: return and remove first value
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            int value = this.first.Value;
            this.first = this.first.next;
            this.count--;
            return value;
        }

        /// <summary>
        /// Clear values
        /// </summary>
        public void Clear()
        {
            this.first = null;
            this.count = 0;
        }

        /// <summary>
        /// Find with value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node Find(int value)
        {
            Node node = null;

            for (Node i = this.first; i != null; i = i.next)
            {
                if (i.Value == value)
                {
                    node = i;
                    break;
                }
            }

            return node;
        }

        /// <summary>
        /// Find last withn value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node FindLast(int value)
        {
            Node node = null;

            for (Node i = this.first; i != null; i = i.next)
            {
                if (i.Value == value)
                {
                    node = i;
                }
            }

            return node;
        }

        /// <summary>
        /// Bubble sort
        /// </summary>
        public void BubbleSort()
        {
            for (Node i = this.first; i != null; i = i.next)
            {
                for (Node j = this.first; j.next != null; j = j.next)
                {
                    if (j.Value > j.next.Value)
                    {
                        Swap(ref j, ref j.next);
                    }
                }
            }
        }

        /// <summary>
        /// Interchange sort
        /// </summary>
        public void InterchangeSort()
        {
            for (Node i = this.first; i.next != null; i = i.next)
            {
                for (Node j = i.next; j != null; j = j.next)
                {
                    if (j.Value > i.Value)
                    {
                        Swap(ref j, ref i);
                    }
                }
            }
        }

        /// <summary>
        /// swap value
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        private void Swap(ref Node node1, ref Node node2)
        {
            int value = node1.Value;
            node1.Value = node2.Value;
            node2.Value = value;
        }

        public void Show()
        {
            for (Node i = this.first; i != null; i = i.next)
            {
                Console.WriteLine(i.Value);
            }
            Console.WriteLine($"count: {this.count}");
        }
    }
}
