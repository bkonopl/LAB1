using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Reflection;

namespace KonLab5.Collections
{
    public class MyList<T> 
    {
        private MyNode<T> _root;
        private MyNode<T> _tail;
        private int _length;
        
        public void Push(T data)
        {
            MyNode<T> node = new MyNode<T>(data);
 
            if (_root == null)
                _root = node;
            else
                _tail.Next = node;
            _tail = node;
 
            _length++;
        }

        public MyNode<T> GetIndex(int index)
        {     
            MyNode<T> node = _root;
            
            while (index-- > 0 )
            {
                node = node.Next;
            }
            
            return node;
        }
        
        public bool Erase(T data)
        {
            MyNode<T> node = _root;
            MyNode<T> prev = null;
 
            while (node != null)
            {
                if (node.Value.Equals(data))
                {
                    if (prev != null)
                    {
                        prev.Next = node.Next;
 
                        if (node.Next == null)
                            _tail = prev;
                    }
                    else
                    {
                        _root = _root.Next;
 
                        if (_root == null)
                            _tail = null;
                    }
                    _length--;
                    return true;
                }
                prev = node;
                node = node.Next;
            }
            return false;
        }
 
        public void Clear()
        {
            _root = null;
            _tail = null;
            _length = 0;
        }

        public int length
        {
            get
            {
                return _length;
            }
        }

        public T this[int index]
        {
            get
            {
                return GetIndex(index).Value;
            }
            set
            {
                GetIndex(index).Value = value;
            }
        }
    }
}