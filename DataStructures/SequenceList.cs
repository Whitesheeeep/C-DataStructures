using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SequenceList<T> : IListDS<T>
    {
        //存储的数据
        private T[] data;
        //存储的数据个数 也是游标
        private int count = 0;

        public SequenceList(int size)//size 就是最大容量
        {
            data = new T[size];
        }

        //默认构造函数 size 为 10
        public SequenceList() : this(10)
        {
        }


        public T? this[int index] => GetElement(index);

        public int GetLength => count;

        public bool IsEmpty() => count == 0;

        public void Add(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("The list is full");
                return;
            }
            else
            {
                data[count] = item;
                count++;
            }
        }

        public void Clear()
        {
            count = 0;

        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public T? GetElement(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is out of range");
                return default(T);
            }
            else
            {
                return data[index];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (data[i]!.Equals(item))
                {
                    return i;
                }
            }
            //值不存在
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Index is out of range");
                return;
            }
            else if (count == data.Length)
            {
                Console.WriteLine("The list is full");
                return;
            }
            else
            {
                for (int i = count - 1; i >= index; i--)
                {
                    data[i + 1] = data[i];
                }
                data[index] = item;
                count++;
            }
        }


        public T? Remove(T item)
        {
            return default(T);
        }

        public T? RemoveAt(int index)
        {
            T temp = data[index];
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = index; i < count - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                count--;
            }
            return temp;
        }
    }
}