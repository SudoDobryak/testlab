﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class StackToArray<T>:IStack<T>
    {
        List<T> _collection;
        public int Count
        {
            get => _collection.Count;
        }
        public StackToArray()
        {
            _collection = new List<T>();
        }
        public StackToArray(ICollection<T> collection) : this()
        {
            _collection.AddRange(collection);
        }

        public void Push(T item)
        {
            _collection.Add(item);
        }

        public T Peek()
        {
            T result;
            try
            {
                result = _collection[Count - 1];
            }
            catch (System.Exception ex)
            {
                throw new System.NullReferenceException(ex.Message, ex);
            }
            return result;
        }

        public T Pop()
        {
            T result;
            try
            {
                result = _collection[Count - 1];
                _collection.RemoveAt(Count - 1);
            }
            catch (System.Exception ex)
            {
                throw new System.InvalidOperationException(ex.Message, ex);
            }
            return result;
        }

        public void Clear() => _collection.Clear();

        public bool Contains(T item) => _collection.Contains(item);

    }
}
