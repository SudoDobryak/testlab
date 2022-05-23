using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public interface IStack<T>
    {
        int Count { get; }
        void Push(T item);
        T Peek();
        T Pop();
        void Clear();
        bool Contains(T item);

    }
}
