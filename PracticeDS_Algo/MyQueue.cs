﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDS_Algo
{
    public class MyQueue<T>
    {
        public MyQueue()
        {
            myList = new DoubleLinkedList<T>();
        }
        DoubleLinkedList<T> myList;

        public int Length { get { return myList.Length; } }

        public void Enqueue(T value)
        {
            myList.AddLast(value);
        }
        public T Dequeue()
        {
            if (IsEmpty()) { throw new IndexOutOfRangeException("Queue is empty!"); }
            T val = myList.FirstVal();
            myList.RemoveFirst();
            return val;
        }

        public T Front()
        {
            if (IsEmpty()) { throw new IndexOutOfRangeException("Queue is empty!"); }
            return myList.FirstVal();
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}
