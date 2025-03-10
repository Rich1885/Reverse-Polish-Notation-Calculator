﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN
{
    internal class LinkedListStack<T> : IStack<T>
    {
        private class Node
        {
            public T Data;
            public Node Next;

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node _top;

        public LinkedListStack()
        {
            _top = null;
        }

        public void Push(T item)
        {
            Node newNode = new Node(item);
            newNode.Next = _top;
            _top = newNode;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Error: Stack underflow! Cannot pop from an empty stack.");

            T data = _top.Data;
            _top = _top.Next;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Error: Stack is empty! Nothing to peek.");

            return _top.Data;
        }
        public bool IsEmpty()
        {
            return _top == null;
        }


    }
}
