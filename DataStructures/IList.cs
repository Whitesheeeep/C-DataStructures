using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface IListDS<T>
    {
        int GetLength { get; }
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(int index, T item);
        T? Remove(T item);
        T? this[int index]{get ;}
        T? RemoveAt(int index);
        T? GetElement(int index);
        int IndexOf(T item);
        bool Contains(T item);
    }
}