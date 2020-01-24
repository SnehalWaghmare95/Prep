using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GraphRepresentation
{
    class HashMap<K,V>
    {
        int size = 0;
        Node<K,V>[] bucket;
        int Max = 10;

        

        public HashMap() {
            bucket = new Node<K,V>[10];
            for (int i = 0; i < 10; i++) {
                bucket[i] = null;
            }
        }

        public int getIndex(K key) {
            int index = key.GetHashCode();
            return (index % Max);
        }

        public void remove(K key) {
           
            Node<K,V> prev = getPrevNode(key);
            if (prev == null) return;
            if (prev.next.key.Equals(key)) {
                size--;
                prev.next = prev.next.next;
            }
       
        }
        public int getSize()
        {
            return size;
        }
        public Boolean IsContains(K key)
        {
            try
            {
                if (get(key) != null)
                {
                    return true;
                }

            }
            catch (Exception e)
            {
                return false;
            }
           
                return false;
            
        }
        public V get(K key) {
            int index = getIndex(key);
            if (bucket[index] == null)
            {
                throw new NullReferenceException();
            }
            Node<K,V> prev = getPrevNode(key);
            if (prev.next == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return prev.next.value;
            }
        }
        public void put(K key, V value) {
            int index = getIndex(key);
            if (bucket[index] == null) {
                bucket[index] = new Node<K,V>(key, value);
                size++;
                return;
            }
            if (bucket[index].key.Equals(key)) {
                bucket[index].value = value;
                return;
            }
            Node<K,V> prev = getPrevNode(key);
            if (prev.next == null)
            {
                size++;
                bucket[index] = new Node<K,V>(key, value);
            }
            else if (prev.next !=null) {
                
                prev.next.value = value;
            }

        }
        public Node<K,V> getPrevNode(K key) {
            int index = getIndex(key);
            Node<K,V> p = bucket[index];
           
            Node<K,V> prev = null;
            while (p != null && !(p.key.Equals(key))) {
                prev = p;
                p = p.next;
            }
            return prev;
        }

     
    }
}
