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
            if (_top + 1 >= _capacity)
                throw new StackOverflowException("Error: Stack overflow! Cannot push more items.");

            _items[++_top] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Error: Stack underflow! Cannot pop from an empty stack.");

            return _items[_top--];
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Error: Stack is empty! Nothing to peek.");

            return _items[_top];
        }

        public bool IsEmpty()
        {
            return _top == -1; 
        }
    }
}
