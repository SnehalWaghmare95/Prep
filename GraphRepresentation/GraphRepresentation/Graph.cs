using System;
using System.Collections.Generic;
using System.Text;

namespace GraphRepresentation
{
    class Graph<T>
    {
        public HashMap<T, ListNode<T>> map;
        public Graph() {
            map = new HashMap<T, ListNode<T>>();
        }
       
        public void addEdge(T source, T destination,bool bidirectional) {
            ListNode<T> node = new ListNode<T>(destination);
            if (!map.IsContains(source))
            {
                map.put(source, node);

            }
            else {
                ListNode<T> p = map.get(source);
                while (p.next != null) {
                    p = p.next;
                }
                p.next = node;

            }
            if (bidirectional) {
                addEdge(destination,source,false);
            }
        }


    }
}
