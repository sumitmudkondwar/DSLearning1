using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.LinkedList
{
    public class Stack<T> : System.Collections.Generic.IEnumerable<T>
    {

        private System.Collections.Generic.LinkedList<T> _list =
            new System.Collections.Generic.LinkedList<T>();

        public void Push(T item)
        {
            _list.AddFirst(item);
        }

        public T Pop()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

            T value = _list.First.Value;
            _list.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (_list.Count == 0)
            {
                throw new InvalidOperationException("The Stack is Empty");
            }

            return _list.First.Value;
        }

        public int Count
        {
            get
            {
                return _list.Count;
            }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
