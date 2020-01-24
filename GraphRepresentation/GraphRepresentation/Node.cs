using System;
using System.Collections.Generic;
using System.Text;

namespace GraphRepresentation
{
    class Node<K,V>
    {

        public V value;
        public K key;
        public Node<K,V> next;
        public Node(K key,V value) {
            this.key = key;
            this.value = value;
            this.next = null;
        }


    }
}
