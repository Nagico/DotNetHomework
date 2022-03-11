using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    public class NodeList<T> : IEnumerable<T>
    {
        private Node<T>? head;
        private Node<T>? tail;

        public NodeList()
        {
            tail = head = null;
        }

        public void Add(T data)
        {
            var new_node = new Node<T>(data);

            if (head == null || tail == null)
            {
                head = tail = new_node;
            }
            else
            {
                tail.Next = new_node;
                tail = new_node;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var cur = head;
            while (cur != null)
            {
                yield return cur.Data;
                cur = cur.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var cur = head;
            while (cur != null)
            {
                yield return cur.Data;
                cur = cur.Next;
            }
        }

        public void ForEach(Action<T> action)
        {
            foreach(var item in this)
            {
                action(item);
            }
        }
    }
}
