using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN
{
    internal class ArrayStack<T> : IStack<T>
    {
        private T[] _items;
        private int _top;
        private int _capacity;

        public ArrayStack(int capacity = 10) 
        {
            _capacity = capacity;
            _items = new T[_capacity];
            _top = -1;
        }

        public void Push(T item)
        {
            _items[++_top] = item;
        }

        public T Pop()
        {
            return _items[_top--];
        }

        public T Peek()
        {
            return _items[_top];
        }

        public bool IsEmpty()
        {
            return _top == -1; 
        }
    }
}
