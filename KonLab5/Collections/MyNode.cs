namespace KonLab5.Collections
{
    public class MyNode<T>
    {
        private T _value;
        private MyNode<T> _next = null;

        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public MyNode<T> Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }

        public MyNode()
        {
            return;
        }
        public MyNode(T value)
        {
            _value = value;
        }
        
    }
}