using System;
using System.Collections.Generic;
using System.Text;

namespace GraphRepresentation
{
    class LinkedList<T>
    {
        ListNode<T> head;
        int size;
        public LinkedList() {
            this.head = null;
            size = 0;
        }
        public void deleteAtFirst() {
            if (size == 0) return;
            else {
                size--;
                head = head.next;
            }
               
        }
        public void deleteAtLast() {
            ListNode<T> p = head,prev =null;
            while (p.next != null)
            {
                prev = p;
                p = p.next;
            }
            prev.next = p.next;
            size--;
        }
        public void deleteAtNthPos(int pos) {
            if (size == 0) return;
            pos = pos - 1;
            if (pos == 0)
            {
                deleteAtFirst();
                return;

            }
            else {
                ListNode<T> p = head;
                while (pos > 0) {
                    p = p.next;
                    pos--;
                }
                p.next = p.next.next;
            }

        }
        public int getSize()
        {
            return size;
        }
        public void addNodeAtFirst(T val) {
            ListNode<T> node = new ListNode<T>(val);
            size++;
            if (head == null) {
                head = node;

            }
            else
            {
                node.next = head;
                head = node;

            }
        }
        public void addAtEnd(T val) {
            size++;
            ListNode <T> p = head;
            if (head == null) {
                addNodeAtFirst(val);
            }
            else {
                ListNode<T> node = new ListNode<T>(val);
                while (p.next != null)
                {
                    p = p.next;
                }
                p.next = node;
            }

        }
        public void addAtNthPosition(T val,int pos)
        {
            size++;
            pos = pos - 1;
            if (pos == 0) {
                addNodeAtFirst(val);
               
            }
            else
            {
                ListNode<T> node = new ListNode<T>(val); 
                ListNode<T> p = head;
                
                while (pos > 0) {
                    p = p.next;
                    pos--;
                }
                node.next = p.next;
                p.next = node;
               
            }
            
        }
    }
}
