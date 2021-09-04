using System;
using KonLab5.Interfaces;

namespace KonLab5.Collections
{
    public class MyCustomCollection<T> : ICustomCollection<T>
    {
        private MyList<T> arr = new MyList<T>();
        private int cursorPointer = 0;

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }

        public void Reset()
        {
            cursorPointer = 0;
        }

        public void Next()
        {
            cursorPointer++;
        }

        public T Current()
        {
            return arr[cursorPointer];
        }

        public int Count
        {
            get { return arr.length; }
        }

        public void Add(T item)
        {
            arr.Push(item);
        }

        public void Remove(T item)
        {
            arr.Erase(item);
        }

        public T RemoveCurrent()
        {
            return arr[cursorPointer];
        }
    }
}