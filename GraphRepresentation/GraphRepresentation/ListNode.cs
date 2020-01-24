using System;
using System.Collections.Generic;
using System.Text;

namespace GraphRepresentation
{
    class ListNode<T>
    {
        public T val;
        public ListNode<T> next;
        public ListNode(T val) {
            this.val = val;
            this.next = null;
        }
    }
}
